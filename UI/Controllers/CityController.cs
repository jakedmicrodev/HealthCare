using Business.Entities;
using Business.Servicess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            List<City> v = new MedicalService().GetCities();
            return View(v);
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(City c)
        {
            MedicalService m = new MedicalService();
            m.CreateCity(c);

            return RedirectToAction("Index");
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            City a = new MedicalService().GetCity(id);
            return View(a);
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(City c)
        {
            MedicalService m = new MedicalService();
            m.EditCity(c);

            return RedirectToAction("Index");
        }
    }
}
