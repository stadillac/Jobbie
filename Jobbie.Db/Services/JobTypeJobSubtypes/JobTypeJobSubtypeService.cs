using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class JobTypeJobSubtypeService : BaseService<JobTypeJobSubtype>, IJobTypeJobSubtypeService
    {
        public JobTypeJobSubtypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
