using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vectores.Models;

namespace Vectores.Models
{


    public class VectorR3 : MatematicaVectorial
    {
        public double valorX;
        public double valorY;
        public double valorZ;
        public double resultado;
        public static double pi = 3.1415;
        public static double e = 2.71828;
        public double  sumar(double valorX , double valorY, double valorZ){
            return valorX + valorY + valorZ;
        }
        public double  restar(double valorX, double valorY, double valorZ)
        {
            return valorX - valorY - valorZ;
        }
        public double productoPunto(double valorX, double valorY, double valorZ){
            return valorX * valorY *valorZ;
        }

        
    }
}