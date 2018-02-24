using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["usuarioId"] = "lquiroga";
            Session["sexo"] = "M";
                
            return View();
        }
    }
}