using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class StateProfile : Profile
    {
        public StateProfile()
        {
            CreateMap<State, StateViewModel>().ReverseMap();
            CreateMap<State, StateEditViewModel>().ReverseMap();
        }
    }
}
