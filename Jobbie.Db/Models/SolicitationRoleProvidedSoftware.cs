namespace Jobbie.Db.Models
{
    public class SolicitationRoleProvidedSoftware : Audit
    {
        public int Id { get; set; }
        public int SolicitationRoleId { get; set; }
        public int SoftwareId { get; set; }

        public virtual SolicitationRole SolicitationRole { get; set; } = new SolicitationRole();
        public virtual Software Software { get; set; } = new Software();
    }
}
