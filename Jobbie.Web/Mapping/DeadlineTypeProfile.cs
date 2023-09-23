using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class DeadlineTypeProfile : Profile
    {
        public DeadlineTypeProfile()
        {
            CreateMap<DeadlineType, DeadlineTypeViewModel>().ReverseMap();
            CreateMap<DeadlineType, DeadlineTypeEditViewModel>().ReverseMap();
        }
    }
}
