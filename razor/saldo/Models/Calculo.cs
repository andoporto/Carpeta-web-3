using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculosaldo.Models
{
    public class Calculo
    {
        private int saldo;

        public void setearSaldo(int monto)
        {
            saldo = monto;
        }
        public int incrementarSaldo(int monto)
        {
            saldo = saldo + monto;
            return saldo;
        }
    }
}