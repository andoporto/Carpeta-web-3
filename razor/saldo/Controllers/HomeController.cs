using Calculosaldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculosaldo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Calculo sal = new Calculo();
            sal.setearSaldo(2000);
            var saldoactual=sal.incrementarSaldo(3000);
            return View(saldoactual);
        }
    }
}