using AutoMapper;
using webapi.DataTransferObjects;
using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi.AutoMapper;

public class AdministrativeUnitProfile: Profile
{
    public AdministrativeUnitProfile()
    {
        CreateMap<Ward, WardDto>();
    }
}