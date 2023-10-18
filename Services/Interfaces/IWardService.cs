using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi.Services.Interfaces;

public interface IWardService
{
    public Task<List<Ward>> getWardsByDistrictCode(string districtCode);
}