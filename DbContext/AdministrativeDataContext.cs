
using webapi.Models.BoardNumber;
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
            .HasOne<AdministrativeUnit>(x => x.AdministrativeUnit)
            .WithMany(a => a.Wards)
            .HasForeignKey(w => w.AdministrativeUnitId);
        
        modelBuilder.Entity<Ward>()
            .HasOne<District>(w => w.District)
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
            .HasOne<AdministrativeUnit>(x => x.AdministrativeUnit)
            .WithMany(a => a.Districts)
            .HasForeignKey(d => d.AdministrativeUnitId);
        
        modelBuilder.Entity<District>()
            .HasOne<Province>(x => x.Province)
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
            .HasOne<AdministrativeUnit>(x => x.AdministrativeUnit)
            .WithMany(a => a.Provinces)
            .HasForeignKey(p => p.AdministrativeUnitId);
        
        modelBuilder.Entity<Province>()
            .Property(p => p.AdministrativeRegionId)
            .HasColumnName("administrative_region_id")
            .HasColumnType("integer");
        
        modelBuilder.Entity<Province>()
            .HasOne<AdministrativeRegion>(x => x.AdministrativeRegion)
            .WithMany(p => p.Provinces)
            .HasForeignKey(p => p.AdministrativeRegionId);

        modelBuilder.Entity<AdministrativeUnit>()
            .ToTable("administrative_units")
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<AdministrativeUnit>()
            .Property(p => p.Id)
            .HasColumnName("id");

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
            .Property(p => p.Id)
            .HasColumnName("id");

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
        
        modelBuilder.Entity<GameUser>()
            .ToTable("game_users")
            .HasKey(p => p.Id)
            ;

       
        
        modelBuilder.Entity<GameUser>()
            .Property(p => p.Id)
            .HasColumnName("id");

        modelBuilder.Entity<GameUser>()
            .Property(p => p.Username)
            .HasColumnName("username")
            .HasColumnType("varchar")
            ;
        
        modelBuilder.Entity<GameUser>()
            .Property(p => p.DeviceId)
            .HasColumnName("device_id")
            .HasColumnType("varchar")
            ;
        
        modelBuilder.Entity<GameUser>()
            .HasIndex(g => g.DeviceId)
            .IsUnique();
        
        modelBuilder.Entity<Room>()
            .ToTable("game_rooms")
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<Room>()
            .Property(p => p.Id)
            .HasColumnName("id");
        
        modelBuilder.Entity<Room>()
            .Property(p => p.Code)
            .HasColumnName("code");
        
        modelBuilder.Entity<Room>()
            .HasIndex(g => g.Code)
            .IsUnique();

        modelBuilder.Entity<Room>()
            .Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<Room>()
            .Property(p => p.Board)
            .HasColumnName("board")
            .HasColumnType("text");
        
        modelBuilder.Entity<Room>()
            .Property(p => p.FirstPlayerId)
            .HasColumnName("first_player_id")
            .HasColumnType("integer");
        
        modelBuilder.Entity<Room>()
            .Property(p => p.SecondPlayerId)
            .HasColumnName("second_player_id")
            .HasColumnType("integer");
        
        modelBuilder.Entity<Room>()
            .Property(p => p.BoardNumber)
            .HasColumnName("game_board")
            .HasColumnType("integer[]");

        modelBuilder.Entity<GameData>().ToTable("game_data").HasKey(g => g.Id);
        modelBuilder.Entity<GameData>()
            .Property(p => p.RoomCode)
            .HasColumnName("room_code")
            .HasColumnType("varchar")
            ;

        modelBuilder.Entity<GameData>()
            .Property(g => g.FirstPlayerId)
            .HasColumnName("first_player_id")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.SecondPlayerId)
            .HasColumnName("second_player_id")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.WinnerId)
            .HasColumnName("winner_id")
            .HasColumnType("varchar");
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.FirstPlayerScore)
            .HasDefaultValue(0)
            .HasColumnName("first_player_score");
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.SecondPlayerScore)
            .HasDefaultValue(0)
            .HasColumnName("second_player_score");
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.AllPlayersReady)
            .HasColumnName("all_players_ready")
            .HasDefaultValue(false)
            ;
        
        modelBuilder.Entity<GameData>()
            .Property(g => g.GameMatrix)
            .HasColumnName("game_matrix")
            .HasColumnType("integer[]")
            .HasDefaultValue(new List<int>())
            ;
        modelBuilder.Entity<GameData>()
            .Property(g => g.FirstPlayerFound)
            .HasColumnName("first_player_founds")
            .HasColumnType("integer[]")
            .HasDefaultValue(new List<int>())
            ;
        modelBuilder.Entity<GameData>()
            .Property(g => g.SecondPlayerFound)
            .HasColumnName("second_player_found")
            .HasColumnType("integer[]")
            .HasDefaultValue(new List<int>())
            ;
    }
}