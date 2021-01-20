using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class TitleController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            List<Title> v = new MedicalService().GetTitles();
            return View(v);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Title a)
        {
            MedicalService m = new MedicalService();
            m.CreateTitle(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Title a = new MedicalService().GetTitle(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Title a)
        {
            MedicalService m = new MedicalService();
            m.EditTitle(a);

            return RedirectToAction("Index");
        }
    }
}