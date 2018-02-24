
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Humano3.Models;

namespace Humano3.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{

			List<Alumno> lista = new List<Alumno>();
			Alumno alumno1 = new Alumno();
			alumno1.Edad = 1;
			alumno1.Dni = 222;
			alumno1.Nombre = "juan";

			Alumno alumno2 = new Alumno();
			alumno2.Edad = 2;
			alumno2.Dni = 333;
			alumno2.Nombre = "pepe";

			Alumno alumno3 = new Alumno();
			alumno3.Edad = 3;
			alumno3.Dni = 444;
			alumno3.Nombre = "carlos";

			lista.Add(alumno1);
			lista.Add(alumno2);
			lista.Add(alumno3);
			return View(lista);        
		}       
	
	}
}