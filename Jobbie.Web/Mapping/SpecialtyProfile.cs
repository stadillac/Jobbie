using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SpecialtyProfile : Profile
    {
        public SpecialtyProfile()
        {
            CreateMap<Specialty, SpecialtyViewModel>().ReverseMap();
            CreateMap<Specialty, SpecialtyEditViewModel>().ReverseMap();
        }
    }
}
