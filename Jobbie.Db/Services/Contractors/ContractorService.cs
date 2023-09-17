using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ContractorService : BaseService<Contractor>, IContractorService
    {
        public ContractorService(ApplicationContext context) : base(context)
        {
        }
    }
}
