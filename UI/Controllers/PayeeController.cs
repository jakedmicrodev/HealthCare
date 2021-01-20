using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PayeeController : Controller
    {
        // GET: Payee
        public ActionResult Index()
        {
            List<Payee> v = new MedicalService().GetPayees();
            return View(v);
        }

        public ActionResult Create()
        {
            Payee c = new MedicalService().GetPayee();
            return View(c);
        }

        [HttpPost]
        public ActionResult Create(Payee a)
        {
            MedicalService m = new MedicalService();
            m.CreatePayee(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Payee a = new MedicalService().GetPayee(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Payee a)
        {
            MedicalService m = new MedicalService();
            m.EditPayee(a);

            return RedirectToAction("Index");
        }
    }
}