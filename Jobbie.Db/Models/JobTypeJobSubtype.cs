namespace Operations.Entity.EntityModels
{
    public class JobTypeJobSubtype : Audit
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public int JobSubtypeId { get; set; }

        public JobType JobType { get; set; }
        public JobSubtype JobSubtype { get; set; }
    }
}
