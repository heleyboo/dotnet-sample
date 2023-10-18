using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi.DbContext;

using Microsoft.EntityFrameworkCore;

public class AdministrativeDataContext: DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<AdministrativeRegion> AdministrativeRegions { get; set; }
    
    public DbSet<AdministrativeUnit> AdministrativeUnits { get; set; }
    
    public DbSet<Province> Provinces { get; set; }
    
    public DbSet<District> Districts { get; set; }
    
    public DbSet<Ward> Wards { get; set; }
    
    public AdministrativeDataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgresDatabase"));
    }
}