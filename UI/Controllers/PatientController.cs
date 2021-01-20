using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;


namespace UI.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            List<Patient> v = new MedicalService().GetPatients();
            return View(v);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient a)
        {
            MedicalService m = new MedicalService();
            m.CreatePatient(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Patient a = new MedicalService().GetPatient(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Patient a)
        {
            MedicalService m = new MedicalService();
            m.EditPatient(a);

            return RedirectToAction("Index");
        }
    }
}