using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ProfessionDisciplineProfile : Profile
    {
        public ProfessionDisciplineProfile()
        {
            CreateMap<ProfessionDiscipline, ProfessionDisciplineViewModel>().ReverseMap();
            CreateMap<ProfessionDiscipline, ProfessionDisciplineEditViewModel>().ReverseMap();
        }
    }
}
