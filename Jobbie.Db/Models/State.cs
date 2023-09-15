namespace Operations.Entity.EntityModels
{
    public class State : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
