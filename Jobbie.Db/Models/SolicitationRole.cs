using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobbie.Db.Models
{
    public class SolicitationRole : Audit
    {
        public int Id { get; set; }
        public int SolicitationId { get; set; }
        public int ProjectDeliverableId  { get; set; }
        public bool HasContractor { get; set; }
            //<-this populates with the Contractor when hired by the Solicitor 
        public bool IsComplete { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; } //<- (this is yes, when Solicitation is active and the Solicitor has activated the SolicitationRole) 
        public double LumpSum { get; set; }
        public double HourlyRate { get; set; }
        public double SignBonus  { get; set; } //<- amount paid when contractor is hired for project. non-refundable. 
        public double Workload  { get; set; }
        public string Description { get; set; } = string.Empty;
            //<-can be populated from existing table, can have multiple 
        public int TechRequired  { get; set; }
            //<-can be populated from existing table, can have multiple 
        public int TechProvided  { get; set; }
            //<-list of technology the solicitor can provide access to 
        public DateTime DeliverableDeadline  { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [contractor terminated].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [contractor terminated]; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>When Contractor is fired by Solicitor the SolicitationRole can be readvertised on the platform</remarks>
        public bool ContractorTerminated  { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [contractor paid].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [contractor paid]; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>Verified by site mods when project complete </remarks>
        public bool ContractorPaid { get; set; }

        /// <summary>
        /// Gets or sets the solicitation.
        /// </summary>
        /// <value>
        /// The solicitation.
        /// </value>
        public Solicitation Solicitation { get; set; } = new Solicitation();

        /// <summary>
        /// Gets or sets the project deliverable.
        /// </summary>
        /// <value>
        /// The project deliverable.
        /// </value>
        public ProjectDeliverable ProjectDeliverable { get; set; } = new ProjectDeliverable();
        
        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        /// <value>
        /// The reviews.
        /// </value>
        public virtual ICollection<Review> Reviews { get; set; } = new Collection<Review>();

        /// <summary>
        /// Gets or sets the required software for the role.
        /// </summary>
        /// <value>
        /// The required software.
        /// </value>
        public virtual ICollection<SolicitationRoleRequiredSoftware> RequiredSoftware { get; set; } = new Collection<SolicitationRoleRequiredSoftware>();

        /// <summary>
        /// Gets or sets the provided software for the role.
        /// </summary>
        /// <value>
        /// The provided software.
        /// </value>
        public virtual ICollection<SolicitationRoleProvidedSoftware> ProvidedSoftware { get; set; } = new Collection<SolicitationRoleProvidedSoftware>();
    }
}
