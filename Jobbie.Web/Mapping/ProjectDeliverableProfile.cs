using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ProjectDeliverableProfile : Profile
    {
        public ProjectDeliverableProfile()
        {
            CreateMap<ProjectDeliverable, ProjectDeliverableViewModel>().ReverseMap();
            CreateMap<ProjectDeliverable, ProjectDeliverableEditViewModel>().ReverseMap();
        }
    }
}
