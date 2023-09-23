using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Address, AddressEditViewModel>().ReverseMap();
        }
    }
}
