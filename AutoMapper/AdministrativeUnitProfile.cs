using AutoMapper;
using webapi.DataTransferObjects;
using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi.AutoMapper;

public class AdministrativeUnitProfile: Profile
{
    public AdministrativeUnitProfile()
    {
        CreateMap<District, DistrictDto>();
        CreateMap<Ward, WardDto>()
            .ForMember(w => w.District, opt => opt.MapFrom(x => x.District));
        CreateMap<Task<List<Ward>>, Task<List<WardDto>>>();
        CreateMap<Task<List<District>>, Task<List<DistrictDto>>>();
    }
}