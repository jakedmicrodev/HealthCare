using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LineItemController : Controller
    {
        // GET: LineItem
        public ActionResult Index(int claimId)
        {
            List<LineItem> v = new MedicalService().GetLineItems(claimId);
            return View(v);
        }

        // GET: LIneItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineItem/Create
        public ActionResult Create(int? id)
        {
            LineItem l = new LineItem();
            if(id != null)
            {
                l.ClaimId = (int)id;
            }

            return View(l);
        }

        // POST: LineItem/Create
        [HttpPost]
        public ActionResult Create(LineItem v)
        {
            MedicalService m = new MedicalService();
            m.CreateLineItem(v);

            return RedirectToAction("Index");
        }

        // GET: LineItem/Edit/5
        public ActionResult Edit(int id)
        {
            LineItem v = new MedicalService().GetLineItem(id);
            return View(v);
        }

        // POST: LineItem/Edit/5
        [HttpPost]
        public ActionResult Edit(LineItem v)
        {
            MedicalService m = new MedicalService();
            m.EditLineItem(v);

            return RedirectToAction("Index");
        }

        // GET: LineItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineItem/Delete/5
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

        [ChildActionOnly]
        public ActionResult Prescriptions(int lineItemId)
        {
            List<Prescription> l = new MedicalService().GetPrescriptions(lineItemId);
            return View(l);
        }


    }
}