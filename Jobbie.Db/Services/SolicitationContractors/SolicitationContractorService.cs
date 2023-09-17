using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class SolicitationContractorService : BaseService<SolicitationContractor>, ISolicitationContractorService
    {
        public SolicitationContractorService(ApplicationContext context) : base(context)
        {
        }
    }
}
