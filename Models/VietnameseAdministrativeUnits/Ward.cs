using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models.VietnameseAdministrativeUnits;

[Table("wards")]
[PrimaryKey("Code")]
public class Ward
{
    [Column("code")]
    public string Code { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("name_en")]
    public string NameEn { get; set; }
    
    [Column("full_name")]
    public string FullName { get; set; }
    
    [Column("full_name_en")]
    public string FullNameEn { get; set; }
    
    [Column("code_name")]
    public string CodeName { get; set; }
    
    [Column("administrative_unit_id")]
    public int AdministrativeUnitId { get; set; }
    
    public AdministrativeUnit AdministrativeUnit { get; set; }

    [ForeignKey("DistrictCode")]
    [Column("district_code")]
    public string DistrictCode { get; set; }
    
    public District District { get; set; }
}