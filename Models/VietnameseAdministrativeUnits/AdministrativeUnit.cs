using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models.VietnameseAdministrativeUnits;

[Table("administrative_units")]
public class AdministrativeUnit
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("full_name")]
    public string FullName { get; set; }
    
    [Column("full_name_en")]
    public string FullNameEn { get; set; }
    
    [Column("short_name")]
    public string ShortName { get; set; }
    
    [Column("short_name_en")]
    public string ShortNameEn { get; set; }
    
    [Column("code_name")]
    public string CodeName { get; set; }
    
    [Column("code_name_en")]
    public string CodeNameEn { get; set; }
    
    public ICollection<Province> Provinces { get; set; }
}