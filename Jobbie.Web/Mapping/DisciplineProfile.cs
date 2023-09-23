using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class DisciplineProfile : Profile
    {
        public DisciplineProfile()
        {
            CreateMap<Discipline, DisciplineViewModel>().ReverseMap();
            CreateMap<Discipline, DisciplineEditViewModel>().ReverseMap();
        }
    }
}
