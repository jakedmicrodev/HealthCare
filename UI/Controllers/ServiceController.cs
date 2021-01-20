using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            List<Service> v = new MedicalService().GetServices();
            return View(v);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Service a)
        {
            MedicalService m = new MedicalService();
            m.CreateService(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Service a = new MedicalService().GetService(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Service a)
        {
            MedicalService m = new MedicalService();
            m.EditService(a);

            return RedirectToAction("Index");
        }
    }
}