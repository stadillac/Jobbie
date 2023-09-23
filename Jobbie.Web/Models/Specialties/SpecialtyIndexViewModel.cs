using X.PagedList;

namespace Jobbie.Web.Models
{
    public class SpecialtyIndexViewModel
    {
        public IPagedList<SpecialtyViewModel> Specialties { get; set; }
    }
}
