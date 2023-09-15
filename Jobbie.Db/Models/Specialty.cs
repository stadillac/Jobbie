namespace Operations.Entity.EntityModels
{
    public class Specialty : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JobSubtypeId { get; set; }

        public virtual JobSubtype JobSubtype { get; set; }
    }
}
