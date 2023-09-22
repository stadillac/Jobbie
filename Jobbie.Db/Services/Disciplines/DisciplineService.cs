using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class DisciplineService : BaseService<Discipline>, IDisciplineService
    {
        public DisciplineService(ApplicationContext context) : base(context)
        {
        }
    }
}
