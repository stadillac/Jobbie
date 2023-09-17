using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class DeadlineTypeService : BaseService<DeadlineType>, IDeadlineTypeService
    {
        public DeadlineTypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
