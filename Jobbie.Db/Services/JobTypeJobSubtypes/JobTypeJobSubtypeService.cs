using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class JobTypeJobSubtypeService : BaseService<JobTypeJobSubtype>, IJobTypeJobSubtypeService
    {
        public JobTypeJobSubtypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
