using MySql.Data.MySqlClient.X.XDevAPI.Common;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ward>()
            .ToTable("wards")
            .HasKey(p => p.Code);

        modelBuilder.Entity<Ward>()
            .Property(p => p.Code)
            .HasColumnName("code")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.NameEn)
            .HasColumnName("name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.FullName)
            .HasColumnName("full_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.FullNameEn)
            .HasColumnName("full_name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.CodeName)
            .HasColumnName("code_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.DistrictCode)
            .HasColumnName("district_code")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Ward>()
            .Property(p => p.AdministrativeUnitId)
            .HasColumnName("administrative_unit_id")
            .HasColumnType("integer");

        modelBuilder.Entity<Ward>()
            .HasOne<AdministrativeUnit>()
            .WithMany(a => a.Wards)
            .HasForeignKey(w => w.AdministrativeUnitId);
        
        modelBuilder.Entity<Ward>()
            .HasOne<District>()
            .WithMany(d => d.Wards)
            .HasForeignKey(w => w.DistrictCode);
        
        modelBuilder.Entity<District>()
            .ToTable("districts")
            .HasKey(p => p.Code);

        modelBuilder.Entity<District>()
            .Property(p => p.Code)
            .HasColumnName("code")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.NameEn)
            .HasColumnName("name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.FullName)
            .HasColumnName("full_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.FullNameEn)
            .HasColumnName("full_name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.CodeName)
            .HasColumnName("code_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.ProvinceCode)
            .HasColumnName("province_code")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<District>()
            .Property(p => p.AdministrativeUnitId)
            .HasColumnName("administrative_unit_id")
            .HasColumnType("integer");

        modelBuilder.Entity<District>()
            .HasOne<AdministrativeUnit>()
            .WithMany(a => a.Districts)
            .HasForeignKey(d => d.AdministrativeUnitId);
        
        modelBuilder.Entity<District>()
            .HasOne<Province>()
            .WithMany(p => p.Districts)
            .HasForeignKey(d => d.ProvinceCode);
        
        modelBuilder.Entity<Province>()
            .ToTable("provinces")
            .HasKey(p => p.Code);

        modelBuilder.Entity<Province>()
            .Property(p => p.Code)
            .HasColumnName("code")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.NameEn)
            .HasColumnName("name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.FullName)
            .HasColumnName("full_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.FullNameEn)
            .HasColumnName("full_name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.CodeName)
            .HasColumnName("code_name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Province>()
            .Property(p => p.AdministrativeUnitId)
            .HasColumnName("administrative_unit_id")
            .HasColumnType("integer");

        modelBuilder.Entity<Province>()
            .HasOne<AdministrativeUnit>()
            .WithMany(a => a.Provinces)
            .HasForeignKey(p => p.AdministrativeUnitId);
        
        modelBuilder.Entity<Province>()
            .Property(p => p.AdministrativeRegionId)
            .HasColumnName("administrative_region_id")
            .HasColumnType("integer");
        
        modelBuilder.Entity<Province>()
            .HasOne<AdministrativeRegion>()
            .WithMany(p => p.Provinces)
            .HasForeignKey(p => p.AdministrativeRegionId);
        
        modelBuilder.Entity<AdministrativeUnit>()
            .ToTable("administrative_units")
            .HasKey(p => p.Id);

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.FullName)
            .HasColumnName("full_name")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.FullNameEn)
            .HasColumnName("full_name_en")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.ShortName)
            .HasColumnName("short_name")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.ShortNameEn)
            .HasColumnName("short_name_en")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.CodeName)
            .HasColumnName("code_name")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.CodeNameEn)
            .HasColumnName("code_name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<AdministrativeRegion>()
            .ToTable("administrative_regions")
            .HasKey(p => p.Id);

        modelBuilder.Entity<AdministrativeRegion>()
            .Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeRegion>()
            .Property(p => p.NameEn)
            .HasColumnName("name_en")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<AdministrativeRegion>()
            .Property(p => p.CodeName)
            .HasColumnName("code_name")
            .HasColumnType("varchar");

        modelBuilder.Entity<AdministrativeRegion>()
            .Property(p => p.CodeNameEn)
            .HasColumnName("code_name_en")
            .HasColumnType("varchar");
        
    }
}