namespace Jobbie.Db.Models
{
    public class Specialty : Audit
    {
        public int Id { get; set; }
        public int ExpertiseId { get; set; }
        public virtual Expertise? Expertise { get; set; }
    }
}
