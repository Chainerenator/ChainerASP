using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ChainerASP.Models;

namespace ChainerASP.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random           
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
           // return View(movie);
            //return Content("IDI NAHUY");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy= "name"}); 
        }
    }
}