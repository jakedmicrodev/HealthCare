using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PrescriptionController : Controller
    {
        // GET: Prescription
        public ActionResult Index()
        {
            List<Prescription> v = new MedicalService().GetPrescriptions();
            return View(v);
        }

        public ActionResult Create(int Id)
        {
            Prescription c = new MedicalService().GetPrescription();
            c.LineItemId = Id;
            return View(c);
        }

        [HttpPost]
        public ActionResult Create(Prescription a)
        {
            MedicalService m = new MedicalService();
            m.CreatePrescription(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Prescription a = new MedicalService().GetPrescription(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Prescription a)
        {
            MedicalService m = new MedicalService();
            m.EditPrescription(a);

            return RedirectToAction("Index");
        }
    }
}