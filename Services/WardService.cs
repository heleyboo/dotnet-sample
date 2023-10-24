using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using webapi.DataTransferObjects;
using webapi.DbContext;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Repositories.Interfaces;
using webapi.Services.Interfaces;

namespace webapi.Services;

public class WardService: IWardService
{
    private readonly AdministrativeDataContext _context;
    
    private readonly IUnitOfWork _unitOfWork;

    public WardService(AdministrativeDataContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }
    
    public IEnumerable<Ward> GetWardsByDistrictCode(string districtCode)
    {
        return _unitOfWork.Ward.Find(s => s.DistrictCode == districtCode);
    }

    public Ward? GetWardByCode(string code)
    {
        var ward = _context.Wards.Find(code);

        return ward;
    }

    public async Task<List<District>> GetAllDistricts()
    {
        return await _context.Districts.ToListAsync();
    }
}