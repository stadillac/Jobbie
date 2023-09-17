using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class SolicitationService : BaseService<Solicitation>, ISolicitationService
    {
        public SolicitationService(ApplicationContext context) : base(context)
        {
        }
    }
}
