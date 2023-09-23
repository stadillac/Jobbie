using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ProfessionProfile : Profile
    {
        public ProfessionProfile()
        {
            CreateMap<Profession, ProfessionViewModel>().ReverseMap();
            CreateMap<Profession, ProfessionEditViewModel>().ReverseMap();
        }
    }
}
