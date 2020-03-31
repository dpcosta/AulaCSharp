using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    class Farenheit : Temperatura
    {
        public Farenheit(double valor) : base(valor)
        {
             
        }

        public override string ToString()
        {
            return Valor + "(F)";
        }
    }
}
