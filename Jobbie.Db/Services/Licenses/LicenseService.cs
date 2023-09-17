using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class LicenseService : BaseService<License>, ILicenseService
    {
        public LicenseService(ApplicationContext context) : base(context)
        {
        }
    }
}
