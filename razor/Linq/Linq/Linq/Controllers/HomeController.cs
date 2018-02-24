using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Linq.Controllers
{
    public class HomeController : Controller
    {
        private empresa2Entities db = new empresa2Entities();

        // GET: Home
        public ActionResult Index()
        {
            return View();  
        }

        public ActionResult Mostrar()
        {
            
            List<Cliente> misEmpleados = db.Cliente.ToList();

            return View("Mostrar", misEmpleados);
        }

        public ActionResult MostrarParesLambda()
        {

            List<Cliente> misEmpleados = db.Cliente.Where(e => e.Id % 2 == 0).ToList();
            return View("Mostrar", misEmpleados);
        }

        public ActionResult MostrarParesLinq()
        {

            List<Cliente> misEmpleados = (from cl in db.Cliente
                                          where cl.Id % 2 == 0
                                            select cl).ToList();

            return View("Mostrar", misEmpleados);
        }
    }
}