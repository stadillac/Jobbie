using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class ContractorService : BaseService<Contractor>, IContractorService
    {
        public ContractorService(ApplicationContext context) : base(context)
        {
        }
    }
}
