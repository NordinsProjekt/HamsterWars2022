using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL;
using HamsterWars_DatabaseSQL.DAL;
using Microsoft.AspNetCore.Mvc;
using HamsterWars_Core.DTO;
using HamsterWars_DatabaseSQL.Models;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<HamsterContext>();
builder.Services.AddTransient<ITournamentRepository, TournamentRepository>();
builder.Services.AddTransient<IHamsterRepository, HamsterRepository>();
builder.Services.AddTransient<IMatchRepository, MatchRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("https://localhost:7092")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/CreateTournament", async ([FromBody]CreateTournamentDTO ct , [FromServices] ITournamentRepository _rep) =>
{
    var request = await _rep.CreateTournament(ct.Contestants,ct.Title);
    if (request >0)
        return Results.Ok(request);
    else
        return Results.BadRequest();
}).WithName("PostCreateTournament");

app.MapPost("/CheckTournament/{id}", async (int id, [FromServices] ITournamentRepository _rep) =>
{
    try
    {
        var request = await _rep.CheckTournamentMatches(id);
        if (request)
            return Results.Ok();
        else
            return Results.BadRequest();
    }
    catch (Exception)
    {
        return Results.Problem("Internal Server Error", null, 500);
    }

}).WithName("CheckTournamentAndGenerateMatches");

app.MapPost("/EndMatch/{id}", async (int id,[FromServices] IMatchRepository _rep) =>
{
    try
    {
        var request = await _rep.EndMatchAndCountVotes(id);
        if (request)
            return Results.Ok();
        else
            return Results.NotFound();
    }
    catch (Exception)
    {
        return Results.Problem("Internal Server Error", null, 500);
    }
}).WithName("EndMatchAndUpdateStats");

app.MapDelete("/hamster/{id}", async (int id,[FromServices] IHamsterRepository _rep) =>
{
    try
    {
        var request = await _rep.DeleteHamster(id);
        if (request)
            return Results.Ok();
        else
            return Results.BadRequest();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        return Results.Problem("Internal Server Error", null, 500);
    }
}).WithName("DeleteHamster");

app.MapPut("/hamster/{id}/Restore", async (int id, [FromServices] IHamsterRepository _rep) =>
{
    try
    {
        var request = await _rep.RestoreHamster(id);
        if (request)
            return Results.Ok();
        else
            return Results.BadRequest();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        return Results.Problem("Internal Server Error", null, 500);
    }
}).WithName("RestoreHamster");


app.MapPost("/matches", async ([FromBody] MatchCreateDTO value, [FromServices] IMatchRepository _rep) =>
{
    //Lägg till FluentValidation för detta.
    if (value.Hamster1Id > 0 || value.Hamster2Id > 0)
    {
        try
        {
            return Results.Ok(await _rep.InsertMatch(value));
        }
        catch (ArgumentException ae)
        {
            return Results.NotFound(ae.Message);
        }
        catch (Exception)
        {
            return Results.StatusCode(500);
        }
    }
    else
    {
        return Results.BadRequest();
    }
}).WithName("AddNewMatch");

app.MapPost("/hamsters", async ([FromBody] HamsterCreateDTO hamster, [FromServices] IHamsterRepository _rep) =>
{
    if (!string.IsNullOrWhiteSpace(hamster.Name) || !string.IsNullOrWhiteSpace(hamster.Loves) || !string.IsNullOrWhiteSpace(hamster.FavFood))
    {
        try
        {
            var result = await _rep.InsertHamsterAsync(hamster);
            if (result.Id > 0) { return Results.Ok(result); }
            return Results.BadRequest();
        }
        catch (Exception)
        {
            return Results.StatusCode(500);
        }
    }
    else
    {
        return Results.BadRequest();
    }
}).WithName("AddNewHamsters").Produces(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status500InternalServerError)
.Produces<int>(StatusCodes.Status200OK);//RequireHost("AddNewHamster");


app.MapPost("/vote", async ([FromBody] VoteDTO vote, [FromServices] IVoteRepository _rep) =>
{
    if (vote.HamsterId > 0 || vote.MatchId > 0)
    {
        try
        {
            var result = await _rep.VoteOnMatch(vote);
            if (result)
                return Results.Ok();
            else
                return Results.NotFound();
        }
        catch (Exception)
        {
            return Results.StatusCode(500);
        }
    }
    else
    {
        return Results.BadRequest();
    }
}).WithName("AddVote");

app.UseCors(MyAllowSpecificOrigins);
app.Run();
