using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult xyz()
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