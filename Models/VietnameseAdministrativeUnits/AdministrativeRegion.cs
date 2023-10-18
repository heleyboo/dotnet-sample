using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models.VietnameseAdministrativeUnits;

[Table("administrative_regions")]
public class AdministrativeRegion
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("name_en")]
    public string NameEn { get; set; }
    
    [Column("code_name")]
    public string CodeName { get; set; }
    
    [Column("code_name_en")]
    public string CodeNameEn { get; set; }
    
    public ICollection<Province> Provinces { get; set; }
}