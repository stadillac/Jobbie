namespace Jobbie.Db.Models
{
    public class JobTypeJobSubtype : Audit
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public int JobSubtypeId { get; set; }

        public virtual JobType JobType { get; set; } = new();
        public virtual JobSubtype JobSubtype { get; set; } = new();
    }
}
