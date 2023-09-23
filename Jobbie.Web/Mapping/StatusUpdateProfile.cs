using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class StatusUpdateProfile : Profile
    {
        public StatusUpdateProfile()
        {
            CreateMap<StatusUpdate, StatusUpdateViewModel>().ReverseMap();
            CreateMap<StatusUpdate, StatusUpdateEditViewModel>().ReverseMap();
        }
    }
}
