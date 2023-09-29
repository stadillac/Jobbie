﻿using Jobbie.Db.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jobbie.Web.Models
{
    public class SolicitationRoleEditViewModel
    {
        public int Id { get; set; }

        [DisplayName("Lump Sum")]
        public double LumpSum { get; set; }

        [DisplayName("Hourly Rate")]
        public double HourlyRate { get; set; }

        [DisplayName("Sign-on Bonus")]
        public double SignBonus { get; set; }

        [Required]
        [DisplayName("Workload (Hours per Week)")]
        public double Workload { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [DisplayName("Deliverable Deadline")]
        [DataType(DataType.Date)]
        public DateTime DeliverableDeadline { get; set; }

        [DisplayName("Contractor Terminated")]
        public bool ContractorTerminated { get; set; }

        [DisplayName("Contractor Paid")]
        public bool ContractorPaid { get; set; }

        [DisplayName("Has Contractor")]
        public bool HasContractor { get; set; }

        [DisplayName("Complete")]
        public bool IsComplete { get; set; }

        [DisplayName("Cancelled")]
        public bool IsCancelled { get; set; }

        [DisplayName("Approved")]
        public bool IsApproved { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [Required]
        [DisplayName("Solicitation")]
        public int SolicitationId { get; set; }
        public SelectList Solicitations { get; set; }

        [Required]
        [DisplayName("Project Deliverable")]
        public int ProjectDeliverableId { get; set; }
        public SelectList ProjectDeliverables { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<SoftwareViewModel> RequiredSoftware { get; set; } = new List<SoftwareViewModel>();

        public List<SoftwareViewModel> ProvidedSoftware { get; set; } = new List<SoftwareViewModel>();
    }
}
