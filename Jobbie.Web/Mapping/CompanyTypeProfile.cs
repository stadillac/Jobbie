using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class CompanyTypeProfile : Profile
    {
        public CompanyTypeProfile()
        {
            CreateMap<CompanyType, CompanyTypeViewModel>().ReverseMap();
            CreateMap<CompanyType, CompanyTypeEditViewModel>().ReverseMap();
        }
    }
}
