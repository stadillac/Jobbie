using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class SolicitorService : BaseService<Solicitor>, ISolicitorService
    {
        public SolicitorService(ApplicationContext context) : base(context)
        {
        }
    }
}
