namespace Jobbie.Db.Models
{
    public class SolicitationDeadline : Audit
    {
        public int Id { get; set; }
        public int SolicitationId { get; set; }
        public int DeadlineTypeId { get; set; }
        public DateTime DeadlineDate { get; set; }

        public virtual Solicitation Solicitation { get; set; } = new();
        public virtual DeadlineType DeadlineType { get; set; } = new();
    }
}
