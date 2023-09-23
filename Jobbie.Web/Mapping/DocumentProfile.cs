using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<Document, DocumentViewModel>().ReverseMap();
            CreateMap<Document, DocumentEditViewModel>().ReverseMap();
        }
    }
}
