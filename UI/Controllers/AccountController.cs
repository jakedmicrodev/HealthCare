using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            List<Account> v = new MedicalService().GetAccounts();
            return View(v);
        }

        public ActionResult Create()
        {
            Account a = new MedicalService().GetAccount();
            return View(a);
        }

        [HttpPost]
        public ActionResult Create(Account a)
        {
            MedicalService m = new MedicalService();
            m.CreateAccount(a);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Account a = new MedicalService().GetAccount(Id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(Account a)
        {
            MedicalService m = new MedicalService();
            m.EditAccount(a);

            return RedirectToAction("Index");
        }
    }

}
