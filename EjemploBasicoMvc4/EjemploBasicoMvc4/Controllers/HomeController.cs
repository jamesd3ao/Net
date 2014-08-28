using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploBasicoMvc4.Models;

namespace EjemploBasicoMvc4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persona = new Persona();
            return View(persona);          
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {           
            return View(persona);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
