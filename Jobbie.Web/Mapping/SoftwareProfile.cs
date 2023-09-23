using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class SoftwareProfile : Profile
    {
        public SoftwareProfile()
        {
            CreateMap<Software, SoftwareViewModel>().ReverseMap();
            CreateMap<Software, SoftwareEditViewModel>().ReverseMap();
        }
    }
}
