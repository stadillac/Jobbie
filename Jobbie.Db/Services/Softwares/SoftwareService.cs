using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SoftwareService : BaseService<Software>, ISoftwareService
    {
        public SoftwareService(ApplicationContext context) : base(context)
        {
        }
    }
}
