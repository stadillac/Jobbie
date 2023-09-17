namespace Jobbie.Db.Models
{
    public class SolicitationContractor : Audit
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int SolicitationId { get; set; }

        public virtual Contractor Contractor { get; set; } = new();
        public virtual Solicitation Solicitation { get; set; } = new();
    }
}
