using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    class FarenheitException : Exception
    {
        public double ValorInformado { get; }

        public FarenheitException(string message, double valorInformado) : base(message)
        {
            ValorInformado = valorInformado;
        }
    }

    class Farenheit : Temperatura
    {
        public Farenheit(double valor) : base(valor)
        {
           if (valor < 0 || valor > 232)
            {
                throw new FarenheitException("Medida inválida para Farenheit!", valor);
            }
        }

        public override string ToString()
        {
            return Valor + "(F)";
        }
    }
}
