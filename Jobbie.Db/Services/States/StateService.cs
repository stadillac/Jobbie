using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class StateService : BaseService<State>, IStateService
    {
        public StateService(ApplicationContext context) : base(context)
        {
        }
    }
}
