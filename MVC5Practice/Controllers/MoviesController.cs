using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVC5Practice.Models;
using MVC5Practice.ViewModels;

namespace MVC5Practice.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "movie1" };
            //return View(movie);
            // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
           // var viewResult = new ViewResult();
           var customers = new List<Customer>()
           {
               new Customer(){Name = "customer1"},
               new Customer(){Name = "customer2"}
           };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);

        }

        [Route("Movies/News/{year:regex(\\d{4}):range(2000,2018)}/{month:regex(\\d{2})}")]
        public ActionResult NewsByDate(int year, int month)
        {
            return Content($"Year={year}&Month={month}");
        }
    }
}