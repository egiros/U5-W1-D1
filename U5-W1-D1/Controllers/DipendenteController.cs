using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U5_W1_D1.Controllers
{
    public class DipendenteController : Controller
    {
        // GET: Dipendente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dipendente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dipendente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dipendente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dipendente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dipendente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dipendente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dipendente/Delete/5
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
