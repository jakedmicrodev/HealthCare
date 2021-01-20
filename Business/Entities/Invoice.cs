using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Invoice
    {
        public int Id { get; set; }

        public int LineItemId { get; set; }

        [Display(Name = "Payee ID")]
        [Required(ErrorMessage = "You must select an account number")]
        public int PayeeId { get; set; }

        [Display(Name = "Payee")]
        [Required(ErrorMessage = "You must select a payee")]
        public string Payee { get; set; }

        public List<SelectListItem> Payees { get; set; }

        [Display(Name = "Account ID")]
        public int AccountId { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        public List<SelectListItem> Accounts { get; set; }

        [Display(Name = "Service ID")]
        public int ServiceId { get; set; }

        [Display(Name = "Service")]
        public string Service { get; set; }

        public List<SelectListItem> Services { get; set; }

        [Display(Name = "Invoice Number")]
        [Required(ErrorMessage = "You must select an invoice number")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "Amount Due")]
        [Required(ErrorMessage = "You must enter an amount")]
        public decimal Amount { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "You must enter a date this invoice is due")]
        public DateTime DueDate { get; set; }

    }
}