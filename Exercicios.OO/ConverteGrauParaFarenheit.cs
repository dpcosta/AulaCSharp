using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    class ConverteGrauParaFarenheit
    {
        static void Main() // dois assuntos: 1 (classes e métodos abstratos)
        {
            // var c = new ConversaoDeTemperatura(); // abstract?
            // var t = new Temperatura(12.9);

            var t1 = new Celsius(12.10);

            try
            {
                Farenheit farenheit = new Farenheit(-48); // 8.88
                Celsius convertido = ConversaoDeTemperatura.ConverteDe(farenheit);
                Console.WriteLine(convertido.Valor);
            }
            catch (FarenheitException e)
            {
                Console.WriteLine($"Você tentou criar uma temperatura em Farenheit com valor inválido. Valor informado: {e.ValorInformado}");
            }
            

            
        }
    }
}
