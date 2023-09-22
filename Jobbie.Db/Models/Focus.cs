using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    public class Focus : Audit
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public virtual Discipline? Discipline { get; set; }
        public virtual ICollection<Expertise> Expertises { get; set; } = new Collection<Expertise>();
    }
}
