using Microsoft.EntityFrameworkCore;
using webapi.DbContext;
using webapi.Services;
using webapi.Services.Interfaces;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<AdministrativeDataContext>();
builder.Services.AddTransient<IWardService, WardService>();

// var loggerFactory = app.Services.GetService<ILoggerFactory>();
// loggerFactory.AddFile(builder.Configuration["Logging:LogFilePath"].ToString());    
// loggerFactory.AddFile("Logs/myapp-{Date}.txt");

Directory.CreateDirectory("Logs");

builder.Logging.AddFile("Logs/myapp.txt");

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