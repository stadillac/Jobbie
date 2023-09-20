using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SolicitationRoleProvidedSoftwareService : BaseService<SolicitationRoleProvidedSoftware>, ISolicitationRoleProvidedSoftwareService
    {
        public SolicitationRoleProvidedSoftwareService(ApplicationContext context) : base(context)
        {
        }
    }
}
