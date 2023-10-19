using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models.VietnameseAdministrativeUnits;

// [Table("provinces")]
// [PrimaryKey("Code")]
public class Province
{
    // [Column("code")]
    public string Code { get; set; }
    
    // [Column("name")]
    public string Name { get; set; }
    
    // [Column("name_en")]
    public string NameEn { get; set; }
    
    // [Column("full_name")]
    public string FullName { get; set; }
    
    // [Column("full_name_en")]
    public string FullNameEn { get; set; }
    
    // [Column("code_name")]
    public string CodeName { get; set; }
    
    // [Column("administrative_unit_id")]
    public int AdministrativeUnitId { get; set; }
    
    public virtual AdministrativeUnit AdministrativeUnit { get; set; }
    
    // [Column("administrative_region_id")]
    public int AdministrativeRegionId { get; set; }
    
    public virtual AdministrativeRegion AdministrativeRegion { get; set; }
    
    public ICollection<District> Districts { get; set; }
}