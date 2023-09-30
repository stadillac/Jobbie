using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ContractorProfile : Profile
    {
        public ContractorProfile()
        {
            CreateMap<Contractor, ContractorViewModel>().ReverseMap();
            CreateMap<Contractor, ContractorEditViewModel>().ReverseMap();
        }
    }
}
