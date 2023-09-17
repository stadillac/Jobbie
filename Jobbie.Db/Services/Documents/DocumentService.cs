using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class DocumentService : BaseService<Document>, IDocumentService
    {
        public DocumentService(ApplicationContext context) : base(context)
        {
        }
    }
}
