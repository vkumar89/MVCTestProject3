﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hello from Student Controller - Index Action method.";
        }

    }
}