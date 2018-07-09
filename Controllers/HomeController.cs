using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brainsman.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descrição";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contato";

            return View();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Message = "Página de cadastro";
            return View();
        }
        public ActionResult Portifolio()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}