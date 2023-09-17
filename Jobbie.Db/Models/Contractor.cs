using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    public class Contractor : Audit
    {
        public int Id { get; set; }
        public int JobTypeJobSubtypeId { get; set; }

        public virtual JobTypeJobSubtype JobTypeJobSubtype { get; set; } = new();
        public virtual Account Account { get; set; } = new();
        public virtual ICollection<License> Licenses { get; set; } = new Collection<License>();
    }
}
