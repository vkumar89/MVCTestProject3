using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class TestController :Controller
    {
        public string Index()
        {
            return "index method from Test Controller";

        }
        public string Show()
        {
            return "Show method from Test Controller";
        }

    }
}