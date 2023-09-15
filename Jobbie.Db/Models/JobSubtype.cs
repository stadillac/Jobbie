namespace Operations.Entity.EntityModels
{
    public class JobSubtype : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasSpecialty { get; set; }
    }
}
