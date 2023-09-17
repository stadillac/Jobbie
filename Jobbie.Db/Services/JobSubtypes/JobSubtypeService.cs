using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class JobSubtypeService : BaseService<JobSubtype>, IJobSubtypeService
    {
        public JobSubtypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
