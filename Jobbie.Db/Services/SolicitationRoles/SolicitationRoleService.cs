using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SolicitationRoleService : BaseService<SolicitationRole>, ISolicitationRoleService
    {
        public SolicitationRoleService(ApplicationContext context) : base(context)
        {
        }
    }
}
