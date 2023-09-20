using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ProjectDeliverableService : BaseService<ProjectDeliverable>, IProjectDeliverableService
    {
        public ProjectDeliverableService(ApplicationContext context) : base(context)
        {
        }
    }
}
