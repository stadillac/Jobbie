using X.PagedList;

namespace Jobbie.Web.Models
{
    public class SolicitorIndexViewModel
    {
        public IPagedList<SolicitorViewModel> Solicitors { get; set; }
    }
}
