using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class FocusService : BaseService<Focus>, IFocusService
    {
        public FocusService(ApplicationContext context) : base(context)
        {
        }
    }
}
