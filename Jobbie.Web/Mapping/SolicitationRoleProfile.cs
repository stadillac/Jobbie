using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SolicitationRoleProfile : Profile
    {
        public SolicitationRoleProfile()
        {
            CreateMap<SolicitationRole, SolicitationRoleViewModel>().ReverseMap();
            CreateMap<SolicitationRole, SolicitationRoleEditViewModel>().ReverseMap();
        }
    }
}
