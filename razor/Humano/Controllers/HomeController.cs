using Humano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Humano.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Alumno p1 = new Alumno();
            p1.Nombre = "andres";
            p1.Dni = 11111;
            p1.Edad = 34;
            return View(p1);
        }
    }
}