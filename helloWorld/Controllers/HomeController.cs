using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index (string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return View("Error");
            else
                return View();
        }

        //public string index(int? id)
        //{
        //    return "hello " + id;
        //}

        //public string Index(string id)
        //{
        //    return @"
        //<html>
        //    <head>
        //        <title>Hello World</title>
        //    </head>
        //    <body>
        //        <p>Hello <span style=""color:red"">" + id + @"</span></p>
        //    </body>
        //</html>";
        //}
    }
}