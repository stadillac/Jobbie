﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jobbie.Web.Models
{
    public class SolicitationEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string County { get; set; } = string.Empty;
        
        [DisplayName("Shared Drive Url")]
        public string SharedDriveUrl { get; set; } = string.Empty;

        [Required]
        [DisplayName("Estimated End Date")]
        [DataType(DataType.Date)]
        public DateTime EstimatedEndDate { get; set; }

        [DisplayName("Team Meeting Time")]
        [DataType(DataType.Time)]
        public DateTime TeamMeetingTime { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Complete")]
        public bool IsComplete { get; set; }

        [DisplayName("Approved")]
        public bool IsApproved { get; set; }

        [DisplayName("Cancelled")]
        public bool IsCancelled { get; set; }

        [Required]
        [DisplayName("State")]
        public int StateId { get; set; }

        public SelectList? States { get; set; }
    }
}
