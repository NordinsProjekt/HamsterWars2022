using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL;
using HamsterWars_DatabaseSQL.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HamsterContext>();
builder.Services.AddTransient<HamsterRepository>();
builder.Services.AddTransient<IHamsterRepository, HamsterRepository>();
builder.Services.AddTransient<IMatchRepository, MatchRepository>();
builder.Services.AddTransient<IMatchResultRepository, MatchResultRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<HamsterContext>();
    dbContext.Database.EnsureCreated();
}
app.Run();
