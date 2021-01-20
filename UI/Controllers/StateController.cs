using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            List<State> v = new MedicalService().GetStates();
            return View(v);
        }

        // GET: State/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: State/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(State s)
        {
            MedicalService m = new MedicalService();
            m.CreateState(s);

            return RedirectToAction("Index");
        }

        // GET: State/Edit/5
        public ActionResult Edit(int id)
        {
            State a = new MedicalService().GetState(id);
            return View(a);
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult Edit(State s)
        {
            MedicalService m = new MedicalService();
            m.EditState(s);

            return RedirectToAction("Index");
        }

        // GET: State/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
