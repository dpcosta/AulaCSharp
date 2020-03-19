using System;

namespace AulaCSharp
{
    /*
     Aula de hoje (19/03/2020):
     - encapsulamento
     - construtores
     - namespaces
     - herança
     - classes abstratas
     - interfaces
     - git / github

         */



    class IndiceDeMassaCorporal // conceito >> OO: classe
    {
        // dados / atributos
        public double peso;
        public double altura;

        // operações / métodos / funções
        public double Calcula() 
        {
            return peso / (altura * altura);
        }

        public void Qualquer()
        {
            // qualquer coisa aqui...
        }
    }

    class NomeQualquer
    {
        static void Main(string[] args) // entry point - ponto de entrada
        {
            IndiceDeMassaCorporal i = new IndiceDeMassaCorporal(); // objeto/instância
            i.peso = 1.89;
            i.altura = 76.89;
            Console.WriteLine(i.Calcula());


            IndiceDeMassaCorporal a = new IndiceDeMassaCorporal(); // objeto/instância
            a.peso = 1.78;
            a.altura = 65.9;

            double imcA = a.Calcula();
            a.Qualquer();

            if (imcA < 25)
            { 
                Console.WriteLine("Peso normal");
            } else
            {
                Console.WriteLine("Sobrepeso");
            }

        }
    }
}
