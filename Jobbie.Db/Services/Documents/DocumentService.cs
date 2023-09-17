using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class DocumentService : BaseService<Document>, IDocumentService
    {
        public DocumentService(ApplicationContext context) : base(context)
        {
        }
    }
}
