using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class FocusProfile : Profile
    {
        public FocusProfile()
        {
            CreateMap<Focus, FocusViewModel>().ReverseMap();
            CreateMap<Focus, FocusEditViewModel>().ReverseMap();
        }
    }
}
