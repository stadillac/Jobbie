using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SolicitorService : BaseService<Solicitor>, ISolicitorService
    {
        public SolicitorService(ApplicationContext context) : base(context)
        {
        }
    }
}
