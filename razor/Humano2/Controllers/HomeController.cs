using Humano2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Humano2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<Alumno> p1 = new List<Alumno>();
            p1.Add(new Alumno());
            return View(p1);
        }
    }
}