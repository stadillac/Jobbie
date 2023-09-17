using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class DeadlineTypeService : BaseService<DeadlineType>, IDeadlineTypeService
    {
        public DeadlineTypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
