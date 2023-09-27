using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class SpecialtyService : BaseService<Specialty>, ISpecialtyService
    {
        public SpecialtyService(ApplicationContext context) : base(context)
        {
        }
    }
}
