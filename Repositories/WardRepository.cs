using webapi.DbContext;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Repositories.Interfaces;

namespace webapi.Repositories;

public class WardRepository: GenericRepository<Ward>, IWardRepository
{
    public WardRepository(AdministrativeDataContext context) : base(context) {}
}