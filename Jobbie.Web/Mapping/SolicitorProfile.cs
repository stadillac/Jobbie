using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SolicitorProfile : Profile
    {
        public SolicitorProfile()
        {
            CreateMap<Solicitor, SolicitorViewModel>().ReverseMap();
            CreateMap<Solicitor, SolicitorEditViewModel>().ReverseMap();
        }
    }
}
