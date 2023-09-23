using X.PagedList;

namespace Jobbie.Web.Models
{
    public class SolicitationIndexViewModel
    {
        public IPagedList<SolicitationViewModel> Solicitations { get; set; }
    }
}
