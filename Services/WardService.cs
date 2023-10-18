using Microsoft.EntityFrameworkCore;
using webapi.DbContext;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Services.Interfaces;

namespace webapi.Services;

public class WardService: IWardService
{
    private readonly AdministrativeDataContext _context;

    public WardService(AdministrativeDataContext context)
    {
        _context = context;
    }
    
    public async Task<List<Ward>> GetWardsByDistrictCode(string districtCode)
    {
        return await _context.Wards.Where(s => s.DistrictCode == districtCode).ToListAsync();
    }
}