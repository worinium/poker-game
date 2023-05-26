using db_manager.lib;
using System.Configuration;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Configure dependency injection
// Add services to the container.
string connectionString = "Server=localhost,1443;Database=poker-game;User Id=sa;Password=Worisoft@123;Encrypt=false;";

DependencyInjectionConfig.Configure(builder.Services, connectionString);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
