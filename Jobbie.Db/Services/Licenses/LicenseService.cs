using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class LicenseService : BaseService<License>, ILicenseService
    {
        public LicenseService(ApplicationContext context) : base(context)
        {
        }
    }
}
