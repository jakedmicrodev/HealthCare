using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Business.Entities
{
    public class LineItem
    {
        public int Id { get; set; }

        [Display (Name ="Claim Number")]
        [Required (ErrorMessage = "You must select a claim number")]
        public int ClaimId { get; set; }

        [Display(Name = "Service")]
        [Required(ErrorMessage = "You must select a service provided")]
        public int ServiceId { get; set; }

        public string Service { get; set; }

        public List<SelectListItem> Services { get; set; }

        [Display(Name = "Service Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "You must enter the date the service was provided")]
        public DateTime ServiceDate { get; set; }

        [Display(Name = "Copay")]
        [Required(ErrorMessage = "You must the copay amount")]
        public decimal CopayAmount { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "You must the amount you owe")]
        public decimal OwedAmount { get; set; }
    }
}