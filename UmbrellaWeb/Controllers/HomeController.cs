using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbrellaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
    
        public ActionResult Contractors()
        {
            base.ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Referafriend()
        {
            base.ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Register()
        {
            base.ViewBag.Message = "Your contact page.";
            return View();
        }
       
        public ActionResult Privacy()
        {
            return View();
        }

   
    }
}