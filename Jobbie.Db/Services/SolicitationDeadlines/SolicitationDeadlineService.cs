using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class SolicitationDeadlineService : BaseService<SolicitationDeadline>, ISolicitationDeadlineService
    {
        public SolicitationDeadlineService(ApplicationContext context) : base(context)
        {
        }
    }
}
