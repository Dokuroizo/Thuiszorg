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
<<<<<<< HEAD
            ViewBag.Message = "Jouw Oma.";
=======
            ViewBag.Message = "Je Vader.";
>>>>>>> e916db989466d47d611b21ee52c9e223d9a91f28

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hier staat onze contact pagina. Stefan past about aan.";

            return View();
        }
    }
}
