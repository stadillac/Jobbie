using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class LicenseProfile : Profile
    {
        public LicenseProfile()
        {
            CreateMap<License, LicenseViewModel>().ReverseMap();
            CreateMap<License, LicenseEditViewModel>().ReverseMap();
        }
    }
}
