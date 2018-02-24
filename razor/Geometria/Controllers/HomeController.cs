using Geometria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Geometria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Esfera e1 = new Esfera(80);
            e1.area = e1.calcularArea();
            e1.volumen = e1.calcularVolumen();          
            return View(e1);
        }
    }
}