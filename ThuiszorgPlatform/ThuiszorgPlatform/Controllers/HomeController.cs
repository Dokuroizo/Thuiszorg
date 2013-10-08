using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThuiszorgPlatform.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Je Vader.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hier staat onze contact pagina. Stefan past about aan.";

            return View();
        }
    }
}
