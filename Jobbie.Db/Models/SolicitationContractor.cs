using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Entity.EntityModels
{
    public class SolicitationContractor : Audit
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int SolicitationId { get; set; }
    }
}
