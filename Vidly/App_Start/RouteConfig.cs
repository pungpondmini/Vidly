using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // Need put  [Route("movies/released/{year}/{month:regex(\\d{2}):range(01,12)}")] in Head Method of Controller.

            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}", // Fix movies/released url
            //    new { controller = "Movie", action = "ByReleaseYear"},
            //    new {year=@"\d{4}",month=@"\d{2}"}  // Fix parameter need to receive 4 and 2 digit.   
            //    //new { year = @"2015|2016", month = @"\d{2}" } // only 2016 or 2016 .
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
