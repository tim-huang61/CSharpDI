using ASPNETMVC5Unity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC5Unity.Controllers
{
    public class HomeController : Controller
    {
        ISayHello _SayHello;
        public HomeController(ISayHello sayHello)
        {
            _SayHello = sayHello;
        }
        public ActionResult Index()
        {
            var foo = _SayHello.Hi("Vulcan");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}