using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVC5Practice.Models;

namespace MVC5Practice.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Id = 1, Name = "movie1"};
            //return View(movie);
            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        }


        public ActionResult NewsByDate(int year , int month)
        {
            return Content($"Year={year}&Month={month}");
        }
    }
}