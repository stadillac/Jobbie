using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class SolicitationService : BaseService<Solicitation>, ISolicitationService
    {
        public SolicitationService(ApplicationContext context) : base(context)
        {
        }
    }
}
