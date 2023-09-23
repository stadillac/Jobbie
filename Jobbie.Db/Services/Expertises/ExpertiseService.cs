using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ExpertiseService : BaseService<Expertise>, IExpertiseService
    {
        public ExpertiseService(ApplicationContext context) : base(context)
        {
        }
    }
}
