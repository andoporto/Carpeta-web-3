using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geometria.Models
{
    public abstract class Figura {
        public int numeroLados;
        public float area;
        public float volumen;
        abstract public float calcularArea();
        abstract public float calcularVolumen();
    }
    public class Esfera : Figura
    {
        public float radio;
        public static float pi = (float)(3.1415);
        public Esfera(int radio )
        {
            this.radio = radio;
            this.numeroLados = 0;
        }// 4*pi*r²
        public override float calcularArea()
        {
           area = (4) * pi * radio * radio;
            return area;
        }// (4/3)*pi*radio³
        public override float calcularVolumen()
        {
            volumen = (4 / 3) * pi *( radio * radio * radio);
            return volumen;
        }
    }
}