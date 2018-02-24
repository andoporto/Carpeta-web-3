using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Response.Cookies["usuario"]["usuarioId"] = "jquiroga";
            Response.Cookies["usuario"]["ultimaVisita"] = DateTime.Now.ToString();
            Response.Cookies["usuario"].Expires = DateTime.Now.AddDays(1);

            return View();
        }
    }
}