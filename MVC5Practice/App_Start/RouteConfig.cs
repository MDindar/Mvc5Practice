using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes comes with most specific one to the general one
            routes.MapRoute(
                "MovieNews",
                "Movies/News/{year}/{month}",
                new {controller = "Movies", action = "NewsByDate"},
                new {year = @"20\d{2}", month = @"\d{2}"});


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
