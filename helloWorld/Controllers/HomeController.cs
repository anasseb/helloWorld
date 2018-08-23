using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using helloWorld.Models;

namespace helloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ChercheClient(string Id)
        {
            ViewData["Nom"] = Id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == Id);
            if(client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
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