using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class SpecialtyService : BaseService<Specialty>, ISpecialtyService
    {
        public SpecialtyService(ApplicationContext context) : base(context)
        {
        }
    }
}
