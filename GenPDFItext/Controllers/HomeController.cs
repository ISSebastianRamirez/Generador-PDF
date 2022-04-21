using GenPDFItext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenPDFItext.Controllers
{
    public class HomeController : Controller
    {
        BDConexion conn = new BDConexion();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CrearPDF()
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
    }
}