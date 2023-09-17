using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class JobTypeService : BaseService<JobType>, IJobTypeService
    {
        public JobTypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
