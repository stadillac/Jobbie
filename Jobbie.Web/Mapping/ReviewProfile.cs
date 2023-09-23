using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewViewModel>().ReverseMap();
            CreateMap<Review, ReviewEditViewModel>().ReverseMap();
        }
    }
}
