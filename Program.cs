using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

public class BlogDataContext : DbContext
{
    static readonly string connectionString = "Server=localhost; User ID=xc_main; Password=asgl2019; Database=xc_main_dev";

    public DbSet<Company> companies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}

public class Company
{
    public int id { get; set; }
    public string name { get; set; }
    public string enterprise_gdt_code { get; set; }
    public bool valid { get; set; }
}