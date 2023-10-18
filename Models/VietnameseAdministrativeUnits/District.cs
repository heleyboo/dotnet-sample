using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models.VietnameseAdministrativeUnits;

[Table("districts")]
[PrimaryKey("Code")]
public class District
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

    [ForeignKey("ProvinceCode")]
    [Column("province_code")]
    public string ProvinceCode { get; set; }
    
    public Province Province { get; set; }
}