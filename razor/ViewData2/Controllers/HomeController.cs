using System.Collections.Generic;
using System.Web.Mvc;
using ViewData2.Models;

namespace ViewData2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Empleado> empleado = new List<Empleado>();
          //  empleado.Add("Juana", "Azurduy");
           
         //   empleado.Add("Pedro","Rodriguez");
           

            ViewData["Empleados"] = empleado;
            return View();

        }
    }
}