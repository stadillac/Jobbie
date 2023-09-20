using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ContractorSoftwareService : BaseService<ContractorSoftware>, IContractorSoftwareService
    {
        public ContractorSoftwareService(ApplicationContext context) : base(context)
        {
        }
    }
}
