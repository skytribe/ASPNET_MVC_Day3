using ASPMVC_Day3_Lab_Validation_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Day3_Lab_Validation_2.Controllers
{
    public class SuperUsersController : Controller
    {
        // GET: SuperUsers
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperUsers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperUsers/Create
        [HttpPost]
        public ActionResult Create(SuperUser superUser)
        {
            
                return View();
            
        }

        // GET: SuperUsers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperUsers/Edit/5
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

        // GET: SuperUsers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperUsers/Delete/5
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
