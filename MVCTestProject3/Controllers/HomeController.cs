using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTestProject3.Controllers
{
    public class HomeController: Controller
    {
        public string Index()
        {
            return "Index Method from Home Controller";
        }
        public string Show()
        {
            return "Test Method from Home Controller";
        }

    }
}