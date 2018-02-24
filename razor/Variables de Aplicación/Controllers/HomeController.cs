using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Variables_de_Aplicación.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           // Response.Write(Application["localidad"].ToString());

            return View();
        }
    }
}