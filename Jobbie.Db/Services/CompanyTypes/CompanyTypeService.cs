using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class CompanyTypeService : BaseService<CompanyType>, ICompanyTypeService
    {
        public CompanyTypeService(ApplicationContext context) : base(context)
        {
        }
    }
}
