using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class StateService : BaseService<State>, IStateService
    {
        public StateService(ApplicationContext context) : base(context)
        {
        }
    }
}
