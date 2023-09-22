using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ProfessionService : BaseService<Profession>, IProfessionService
    {
        public ProfessionService(ApplicationContext context) : base(context)
        {
        }
    }
}
