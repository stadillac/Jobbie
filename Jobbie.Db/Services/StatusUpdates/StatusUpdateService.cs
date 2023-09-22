using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class StatusUpdateService : BaseService<StatusUpdate>, IStatusUpdateService
    {
        public StatusUpdateService(ApplicationContext context) : base(context)
        {
        }
    }
}
