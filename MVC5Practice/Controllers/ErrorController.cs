using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Practice.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Error
        public ActionResult NotFound()
        {
            ViewBag.TabTitle = "Page Not Found";
            Response.StatusCode = 404;
            return View();
        }
    }
}