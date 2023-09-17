using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class JobSubtypeService : BaseService<JobSubtype>, IJobSubtypeService
    {
        public JobSubtypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
