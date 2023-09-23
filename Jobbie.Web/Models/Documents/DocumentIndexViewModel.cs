using X.PagedList;

namespace Jobbie.Web.Models
{
    public class DocumentIndexViewModel
    {
        public IPagedList<DocumentViewModel> Documents { get; set; }
    }
}
