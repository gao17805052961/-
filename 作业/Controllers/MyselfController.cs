using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 作业.Controllers
{
    public class MyselfController : Controller
    {
        // GET: Myself
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Myself()
        {
            return View();
        }

        // GET: Myself/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Myself/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Myself/Create
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

        // GET: Myself/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Myself/Edit/5
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

        // GET: Myself/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Myself/Delete/5
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
