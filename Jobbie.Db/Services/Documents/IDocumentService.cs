using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public interface IDocumentService : IBaseService<Document>
    {
        /// <summary>
        /// Approves the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Document Approve(Document document);

        /// <summary>
        /// Denies the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Document Deny(Document document);
    }
}
