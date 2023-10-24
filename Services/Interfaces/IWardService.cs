using webapi.DataTransferObjects;
using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi.Services.Interfaces;

public interface IWardService
{
    public IEnumerable<Ward> GetWardsByDistrictCode(string districtCode);

    public Ward? GetWardByCode(string code);

    public Task<List<District>> GetAllDistricts();
}