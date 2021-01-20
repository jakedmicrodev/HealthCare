using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Index()
        {
            List<Provider> v = new MedicalService().GetProviders();
            return View(v);
        }

        public ActionResult Create()
        {
            Provider a = new MedicalService().GetProvider();
            return View(a);
        }

        [HttpPost]
        public ActionResult Create(Provider a)
        {
            MedicalService m = new MedicalService();
            m.CreateProvider(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Provider a = new MedicalService().GetProvider(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Provider a)
        {
            MedicalService m = new MedicalService();
            m.EditProvider(a);

            return RedirectToAction("Index");
        }
    }
}