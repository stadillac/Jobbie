using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ExpertiseProfile : Profile
    {
        public ExpertiseProfile()
        {
            CreateMap<Expertise, ExpertiseViewModel>().ReverseMap();
            CreateMap<Expertise, ExpertiseEditViewModel>().ReverseMap();
        }
    }
}
