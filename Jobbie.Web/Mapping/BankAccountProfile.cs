using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Web.Models;

namespace Jobbie.Web.Mapping
{
    public class BankAccountProfile : Profile
    {
        public BankAccountProfile()
        {
            CreateMap<BankAccount, BankAccountViewModel>().ReverseMap();
            CreateMap<BankAccount, BankAccountEditViewModel>().ReverseMap();
        }
    }
}
