using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class InvoiceSearch
    {
        #region Invoice Properties

        [Display(Name = "Payee")]
        public int PayeeId { get; set; }
        public List<SelectListItem> Payees { get; set; }

        [Display(Name = "Account Number")]
        public int AccountId { get; set; }
        public List<SelectListItem> Accounts { get; set; }

        [Display(Name = "Service")]
        public int ServiceId { get; set; }
        public List<SelectListItem> Services { get; set; }

        [Display(Name = "Invoice Number")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "Amount Due")]
        public decimal Amount { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        #endregion

        #region Line Item Properties

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

        #endregion

    }
}