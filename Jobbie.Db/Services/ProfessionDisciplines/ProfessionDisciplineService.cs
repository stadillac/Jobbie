using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ProfessionDisciplineService : BaseService<ProfessionDiscipline>, IProfessionDisciplineService
    {
        public ProfessionDisciplineService(ApplicationContext context) : base(context)
        {
        }
    }
}
