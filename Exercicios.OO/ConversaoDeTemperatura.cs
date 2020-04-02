using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    static class ConversaoDeTemperatura // 
    {
        // propriedades, métodos, etc.
        //public int Qualquer { get; set; } // membro de instância (new)

        public static Celsius ConverteDe(Farenheit temperatura)
        {
            double transformacao = (temperatura.Valor - 32) / 1.8000;
            return new Celsius(transformacao);
        }

        public static Farenheit ConverteDe(Celsius temp)
        {
            double transformacao = 12901;
            return new Farenheit(transformacao);
        }
    }
}
