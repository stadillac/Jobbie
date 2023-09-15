using System.Collections.Generic;

namespace Operations.Entity.EntityModels
{
    public class Contractor : Audit
    {
        public int Id { get; set; }
        public int JobTypeJobSubtypeId { get; set; }
    }
}
