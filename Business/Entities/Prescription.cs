using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Prescription
    {
        public int Id { get; set; }

        [Display(Name = "Medication ID")]
        [Required(ErrorMessage = "You must select a medication")]
        public int MedicationId { get; set; }

        [Display(Name = "Medication")]
        public string Medication { get; set; }

        public List<SelectListItem> Medications { get; set; }

        public int LineItemId { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "You must enter an amount paid")]
        public decimal Amount { get; set; }
    }
}