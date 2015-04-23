using Lab3_ModelState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Lab3_ModelState.Controllers
{
    public class CoffeesController : Controller
    {
        // GET: Coffees
        public ActionResult Index()
        {
            return View();
        }

        // GET: Coffees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coffees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coffees/Create
        [HttpPost]
        public ActionResult Create(Coffee coffee)
        {
             

                // TODO: Add insert logic here




                if (String.IsNullOrWhiteSpace(coffee.TypeOfCoffee))
                {
                    ModelState.AddModelError("TypeOfCoffee", "You must specifiy the coffee type!");

                }

                if (coffee.Temperature < 0 || coffee.Temperature > 100)
                {
                    ModelState.AddModelError("Temperature", "Temperature must be between 0 - 100");
                }
                if (coffee.Price <= 0)
                {
                    ModelState.AddModelError("Price", "Price must be greater than 0");
                }

                    
    ////Validate
    //if (!ModelState.IsValid)
    //{
    //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    //    foreach (var item in  ModelState )
    //    {
    //        if (item.Value.Errors.Count > 0)
    //        {
    //            sb.Append("[" + item.Key + "]: ");
    //            foreach (var err in item.Value.Errors)
    //            {
    //                sb.Append(err.ErrorMessage + "  ");

    //            }
    //        }
    //    }
    //    var errorMessage = sb.ToString();
 
    //}




                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }

         
                return View();
          
        }

        // GET: Coffees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coffees/Edit/5
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

        // GET: Coffees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coffees/Delete/5
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
