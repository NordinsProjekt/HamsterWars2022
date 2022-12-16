using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL;
using HamsterWars_DatabaseSQL.DAL;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<HamsterContext>();
builder.Services.AddTransient<ITournamentRepository, TournamentRepository>();
builder.Services.AddTransient<IHamsterRepository, HamsterRepository>();
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
})
.WithName("PostCreateTournament");

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
})
.WithName("DeleteHamster");

app.Run();
