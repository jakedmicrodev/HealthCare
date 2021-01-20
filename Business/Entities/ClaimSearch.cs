using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class ClaimSearch
    {
        [Display(Name = "Patient")]
        public int PatientId { get; set; }
        public List<SelectListItem> Patients { get; set; }

        [Display(Name = "Provider")]
        public int ProviderId { get; set; }
        public List<SelectListItem> Providers { get; set; }

        [Display(Name = "Service")]
        public int ServiceId { get; set; }
        public List<SelectListItem> Services { get; set; }

        [Display(Name = "Claim Number")]
        public string ClaimNumber { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Copay")]
        public decimal CopayAmount { get; set; }

        [Display(Name = "Amount")]
        public decimal OwedAmount { get; set; }
    }
}