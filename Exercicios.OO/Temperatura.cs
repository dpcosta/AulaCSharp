using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    abstract class Temperatura
    {
        public Temperatura(double valor) // obrigatoriedade!
        {
            Valor = valor;
        }

        public double Valor { get; }
    }
}
