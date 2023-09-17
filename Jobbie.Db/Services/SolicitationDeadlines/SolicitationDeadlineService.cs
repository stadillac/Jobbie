using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SolicitationDeadlineService : BaseService<SolicitationDeadline>, ISolicitationDeadlineService
    {
        public SolicitationDeadlineService(ApplicationContext context) : base(context)
        {
        }
    }
}
