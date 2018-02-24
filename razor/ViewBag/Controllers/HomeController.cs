using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> empleado = new List<string>();
            empleado.Add("Juana");
           
            empleado.Add("Pedro");
           

            ViewBag.Empleados = empleado;

            return View();
        }
    }
}