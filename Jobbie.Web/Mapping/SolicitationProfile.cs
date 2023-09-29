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
            CreateMap<SolicitationEditViewModel, Solicitation>();
            CreateMap<Solicitation, SolicitationEditViewModel>()
                .ForMember(dest => dest.States, opt => opt.Ignore());
        }
    }
}
