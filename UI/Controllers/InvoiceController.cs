using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            List<Invoice> v = new MedicalService().GetInvoices();
            return View(v);
        }

        public ActionResult Create(int Id)
        {
            Invoice c = new MedicalService().GetInvoice();
            c.LineItemId = Id;
            return View(c);
        }

        [HttpPost]
        public ActionResult Create(Invoice a)
        {
            MedicalService m = new MedicalService();
            m.CreateInvoice(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Invoice a = new MedicalService().GetInvoice(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Invoice a)
        {
            MedicalService m = new MedicalService();
            m.EditInvoice(a);

            return RedirectToAction("Index");
        }

        public ActionResult SearchChoice()
        {
            return View();
        }

        public ActionResult SearchByInvoice()
        {
            Invoice i = new MedicalService().GetInvoice();
            InvoiceSearch s = new InvoiceSearch();

            s.Accounts = i.Accounts;
            s.Payees = i.Payees;

            return View(s);
        }

        [HttpPost]
        public ActionResult SearchByInvoice(InvoiceSearch s)
        {
            Invoice i = new Invoice();
            i.AccountId = s.AccountId;
            i.PayeeId = s.PayeeId;
            i.InvoiceNumber = s.InvoiceNumber;

            List<Invoice> v = new MedicalService().GetInvoices(i);
            TempData["Invoices"] = v;
            return Redirect("SearchResults");
        }

        public ActionResult SearchByLineItem()
        {
            LineItem l = new MedicalService().GetLineItem();
            InvoiceSearch s = new InvoiceSearch();

            s.Services = l.Services;
            return View(s);
        }

        [HttpPost]
        public ActionResult SearchByLineItem(ClaimSearch cs)
        {

            List<Claim> v = new MedicalService().GetClaimsByLineItem(cs);
            TempData["Invoices"] = v;
            return Redirect("SearchResults");
        }

        public ActionResult SearchResults()
        {
            List<Invoice> v = TempData["Invoices"] as List<Invoice>;
            return View(v);
        }


    }
}