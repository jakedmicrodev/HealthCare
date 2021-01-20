using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ClaimController : Controller
    {
        // GET: Claim
        public ActionResult Index()
        {
            List<Claim> v = new MedicalService().GetClaims();
            return View(v);
        }

        public ActionResult Create()
        {
            Claim c = new MedicalService().GetClaim();
            return View(c);
        }

        [HttpPost]
        public ActionResult Create(Claim c)
        {
            MedicalService m = new MedicalService();
            m.CreateClaim(c);

            return RedirectToAction("Index");
        }

        // GET: Claim/Details/5
        public ActionResult Details(int id)
        {
            Claim c = new MedicalService().GetClaim(id);
            return View(c);
        }

        public ActionResult Edit(int Id)
        {
            Claim c = new MedicalService().GetClaim(Id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Claim c)
        {
            MedicalService m = new MedicalService();
            m.EditClaim(c);

            return RedirectToAction("Index");
        }

        public ActionResult EditLineItem(int Id)
        {
            return Redirect("/LineItem/Edit/" + Id);
        }

        [ChildActionOnly]
        public ActionResult LineItems(int claimId)
        {
            List<LineItem> v = new MedicalService().GetLineItems(claimId);
            return View(v);
        }

        [ChildActionOnly]
        public ActionResult LineItemsDetails(int claimId)
        {
            List<LineItem> v = new MedicalService().GetLineItems(claimId);
            return View(v);
        }

        public ActionResult SearchChoice()
        {
            return View();
        }

        public ActionResult SearchByClaim()
        {
            Claim c = new MedicalService().GetClaim();
            ClaimSearch cs = new ClaimSearch();

            cs.Patients = c.Patients;
            cs.Providers = c.Providers;

            return View(cs);
        }

        [HttpPost]
        public ActionResult SearchByClaim(ClaimSearch cs)
        {
            Claim c = new Claim();
            c.PatientId = cs.PatientId;
            c.ProviderId = cs.ProviderId;
            c.ClaimNumber = cs.ClaimNumber;

            List<Claim> v = new MedicalService().GetClaims(c);
            TempData["Claims"] = v;
            return Redirect("SearchResults");
        }

        public ActionResult SearchByLineItem()
        {
            LineItem l = new MedicalService().GetLineItem();
            ClaimSearch cs = new ClaimSearch();

            cs.Services = l.Services;
            return View(cs);
        }

        [HttpPost]
        public ActionResult SearchByLineItem(ClaimSearch cs)
        {

            List<Claim> v = new MedicalService().GetClaimsByLineItem(cs);
            TempData["Claims"] = v;
            return Redirect("SearchResults");
        }

        public ActionResult SearchResults()
        {
            List<Claim> v = TempData["Claims"] as List<Claim>;
            return View(v);
        }

        public ActionResult CreateInvoice(int Id)
        {
            return Redirect("/Invoice/Create/" + Id);
        }

        public ActionResult CreatePrescription(int Id)
        {
            return Redirect("/Prescription/Create/" + Id);
        }
    }
}