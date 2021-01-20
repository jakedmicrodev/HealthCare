using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Claim
    {
        public int Id { get; set; }

        [Display (Name="PatientID")]
        [Required(ErrorMessage = "You must select a patient")]
        public int PatientId { get; set; }

        [Display(Name = "Patient")]
        public string Patient { get; set; }

        public List<SelectListItem> Patients { get; set; }

        [Display(Name = "ProviderID")]
        [Required(ErrorMessage = "You must select a provider")]
        public int ProviderId { get; set; }

        [Display(Name = "Provider")]
        public string Provider { get; set; }

        public List<SelectListItem> Providers { get; set; }

        [Display(Name = "Claim Number")]
        [Required(ErrorMessage = "You must enter a claim number")]
        public string ClaimNumber { get; set; }
    }
}