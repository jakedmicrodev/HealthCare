using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Account
    {
        public int Id { get; set; }

        [Display(Name = "PayeeID")]
        [Required(ErrorMessage = "You must select a payee")]
        public int PayeeId { get; set; }

        [Display(Name = "Payee")]
        public string Payee { get; set; }

        public List<SelectListItem> Payees { get; set; }

        [Display(Name = "Account Number")]
        [Required(ErrorMessage ="You must enter an accout number")]
        public string Number { get; set; }
    }
}