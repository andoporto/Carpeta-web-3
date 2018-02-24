using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            TempData["Student"] = Student;

            return View();
        }
    }
}