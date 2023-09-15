namespace Operations.Entity.EntityModels
{
    public class SolicitationDeadline : Audit
    {
        public int Id { get; set; }
        public int SolicitationId { get; set; }
        public int DeadlineTypeId { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
