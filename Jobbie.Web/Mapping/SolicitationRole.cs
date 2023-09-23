using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SolicitationProfile : Profile
    {
        public SolicitationProfile()
        {
            CreateMap<Solicitation, SolicitationViewModel>().ReverseMap();
            CreateMap<Solicitation, SolicitationEditViewModel>().ReverseMap();
        }
    }
}
