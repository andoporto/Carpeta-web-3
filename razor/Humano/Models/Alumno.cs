using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humano.Models
{
    public class Alumno : Persona
    {

        public int Edad;

        public Alumno(string nombre):base()
        {
            Edad = 18;
        }
            
   
        public Alumno(int edad):this()
        {
            this.Edad = edad;
        }
        public Alumno()
        {
            this.Nombre = "NN";
        }
    }
}