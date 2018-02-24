using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vectores.Models
{
    public interface MatematicaVectorial
    {
        
         double sumar(double valorX, double valorY, double valorZ);
         double restar(double valorX, double valorY, double valorZ);
         double productoPunto(double valorX, double valorY, double valorZ);
    }
}