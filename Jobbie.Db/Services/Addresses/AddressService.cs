using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class AddressService : BaseService<Address>, IAddressService
    {
        public AddressService(ApplicationContext context) : base(context)
        {
        }
    }
}
