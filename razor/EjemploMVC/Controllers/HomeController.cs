using EjemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var libros = new List<Libro>
            {
                new Libro { Isbn="1122", Titulo="El principito",TipoLibro="Novela" },
                new Libro { Isbn="1123", Titulo="Steve Jobs",TipoLibro="Biografía" }
            };
            return View(libros);
        }
    }
}