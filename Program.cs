using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using webapi.AutoMapper;
using webapi.DbContext;
using webapi.Hubs;
using webapi.Repositories;
using webapi.Repositories.Interfaces;
using webapi.Services;
using webapi.Services.Interfaces;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<AdministrativeDataContext>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IWardService, WardService>();
builder.Services.AddTransient<IGameUserService, GameUserService>();
builder.Services.AddAutoMapper(typeof(AdministrativeUnitProfile));
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

Directory.CreateDirectory("Logs");

builder.Logging.AddFile("Logs/myapp.txt");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();
app.UseRouting();
app.MapControllers();
app.MapRazorPages();
app.MapHub<ChatHub>("/chatHub");
app.MapHub<GameHub>("/gameHub");

app.Run();