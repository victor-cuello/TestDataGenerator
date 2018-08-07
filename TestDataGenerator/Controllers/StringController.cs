using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDataGenerator.Controllers
{
    public class StringController : Controller
    {
        // GET: String
        public ActionResult Strings()
        {
            return View();
        }
    }
}