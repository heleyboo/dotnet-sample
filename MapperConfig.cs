using AutoMapper;
using webapi.DataTransferObjects;
using webapi.Models.VietnameseAdministrativeUnits;

namespace webapi;

using AutoMapper;
public class MapperConfig
{
    public static Mapper InitializeAutomapper()
    {
        //Provide all the Mapping Configuration
        var config = new MapperConfiguration(cfg =>
        {
            //Configuring Employee and EmployeeDTO
            cfg.CreateMap<District, DistrictDto>();
            cfg.CreateMap<Ward, WardDto>()
                .ForMember(w => w.District, opt => opt.MapFrom(x => x.District));
            cfg.CreateMap<Task<List<Ward>>, Task<List<WardDto>>>();
            //Any Other Mapping Configuration ....
        });

        //Create an Instance of Mapper and return that Instance
        var mapper = new Mapper(config);
        return mapper;
    }
}