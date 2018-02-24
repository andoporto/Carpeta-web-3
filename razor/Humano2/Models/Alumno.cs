using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humano2.Models
{
    

    public class Alumno : Persona
    {

        public int Edad;
        List<Alumno> lista = new List<Alumno>();

        public Alumno(string nombre):base()
        {
            Edad = 18;
            if (lista.Count == 0)
            {
                this.altaAlumno(1111, "Julian", 20);
                this.altaAlumno(2222, "Pedro", 30);
                this.altaAlumno(3333, "Pablo", Edad);
            }
        }
            
   
        public Alumno(int edad):this()
        {
            this.Edad = edad;
        }
        public Alumno()
        {
            this.Nombre = "NN";
        }

       

        public void altaAlumno(int Dni, string Nombre, int Edad)
        {
            lista.Add(new Alumno() { Dni = Dni, Nombre = Nombre, Edad = Edad });
        }

       

        

        
    }

   


}