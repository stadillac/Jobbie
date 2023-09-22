using Jobbie.Db.Models;

namespace Jobbie.Web.Models
{
    public class SpecialtyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int JobSubtypeId { get; set; }
        //public JobSubtypeViewModel? JobSubtype { get; set; }
    }
}
