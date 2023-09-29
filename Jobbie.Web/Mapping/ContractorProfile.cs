using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class ContractorProfile : Profile
    {
        public ContractorProfile()
        {
            CreateMap<Contractor, ContractorViewModel>().ReverseMap();
            CreateMap<Contractor, ContractorEditViewModel>()
                .ForMember(
                    dest => dest.ProfessionId, 
                    opt => opt.MapFrom(
                        src => (src.ProfessionDiscipline != null ? src.ProfessionDiscipline.ProfessionId : 0)
                    )
                )
                .ForMember(
                    dest => dest.DisciplineId,
                    opt => opt.MapFrom(
                        src => (src.ProfessionDiscipline != null ? src.ProfessionDiscipline.DisciplineId : 0)
                    )
                );

            // TODO Stopped here
            //CreateMap<ContractorEditViewModel, Contractor>()
            //    .ForMember(dest => dest.ProfessionDiscipline, opt => opt.)
        }
    }
}
