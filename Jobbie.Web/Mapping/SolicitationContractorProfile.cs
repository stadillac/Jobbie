using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SolicitationContractorProfile : Profile
    {
        public SolicitationContractorProfile()
        {
            CreateMap<SolicitationContractor, SolicitationContractorViewModel>().ReverseMap();
            CreateMap<SolicitationContractor, SolicitationContractorEditViewModel>().ReverseMap();
        }
    }
}
