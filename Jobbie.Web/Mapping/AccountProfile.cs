using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<User, AccountViewModel>().ReverseMap();
            CreateMap<User, AccountEditViewModel>().ReverseMap();
        }
    }
}
