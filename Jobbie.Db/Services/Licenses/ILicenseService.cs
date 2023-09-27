using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public interface ILicenseService : IBaseService<License>
    {
        License Verify(License license);
    }
}
