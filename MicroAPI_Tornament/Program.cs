using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL;
using HamsterWars_DatabaseSQL.DAL;
using Microsoft.AspNetCore.Mvc;

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
                              policy.WithOrigins("https://localhost:7092",
                                                  "http://www.contoso.com")
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


app.MapPost("/CreateTournament", async ([FromBody]int[] hamstersId, string title, [FromServices] ITournamentRepository _rep) =>
{
    var request = await _rep.CreateTournament(hamstersId,title);
    if (request)
        return Results.Ok();
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
app.UseCors(MyAllowSpecificOrigins);
app.Run();
