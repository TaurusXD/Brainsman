using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brainsman.Models;

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
            return View(); 
        }
        public ActionResult Portifolio()
        {
            ViewBag.Message = "Portifólio";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Página de Login";
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
    }
}