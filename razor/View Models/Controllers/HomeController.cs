using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Models.Models;


namespace View_Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmpleadoView empleado = new EmpleadoView();
            empleado.Nombre = "Juana";
            empleado.Apeliido ="Pedro";

             return View(empleado);

        }
    }
}