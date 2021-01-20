using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class MedicationController : Controller
    {
        // GET: Medication
        public ActionResult Index()
        {
            List<Medication> a = new MedicalService().GetMedications();
            return View(a);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Medication a)
        {
            MedicalService m = new MedicalService();
            m.CreateMedication(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Medication a = new MedicalService().GetMedication(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Medication a)
        {
            MedicalService m = new MedicalService();
            m.EditMedication(a);

            return RedirectToAction("Index");
        }

    }
}