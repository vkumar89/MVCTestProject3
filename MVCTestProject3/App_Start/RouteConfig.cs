using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTestProject3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Student",
                url: "NIT/Students",
                defaults: new { controller = "Student", action = "Index" }
            );

            //routes.MapRoute(
            //    name: "Student",
            //    url: "Nit/{controller}/{action}",
            //    defaults: new { controller = "Test", action = "Index" }
            //);


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{name}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional,name=UrlParameter.Optional }
            );
        }
    }
}
