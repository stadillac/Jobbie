using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SolicitationRoleRequiredSoftwareService : BaseService<SolicitationRoleRequiredSoftware>, ISolicitationRoleRequiredSoftwareService
    {
        public SolicitationRoleRequiredSoftwareService(ApplicationContext context) : base(context)
        {
        }
    }
}
