using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vectores.Models;

namespace Vectores.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
                 
            return View();
        }

        public ActionResult Suma()
        {
            VectorR3 sum = new VectorR3();
            float s = (float)sum.sumar(40, 80, 90);
            sum.resultado = s;
            return View(sum);
        }

        public ActionResult Resta()
        {
            VectorR3 res = new VectorR3();
            float r = (float)res.restar(40, 80, 90);
            res.resultado = r;
            return View(res);
        }

        public ActionResult Multiplicacion()
        {
            VectorR3 mul = new VectorR3();
            float m = (float)mul.productoPunto(40, 80, 90);
            mul.resultado = m;
            return View(mul);
        }
    }
}