using System;

namespace Exercicios.OO
{
    class Program
    {
        /*
         Utilize orientação a objetos para resolver os problemas abaixo.

        1) Imprima no console cartas de um baralho. Uma carta possui um naipe (ouros, espadas, copas e paus), uma figura (ás, dama, valete, rei, coringa) ou número (2 a 10).

        2) Imprima no console a conversão de temperatura de graus para farenheit.

        3) Escreva o código para representar o conceito de um Livro. Considere que um livro está associado a outros conceitos: páginas, capítulos, autores, editora, imagem de capa. Além disso escreva também classes para Ebooks, Livro Físico e Revistas.

             */
        static void Main(string[] args)
        {
            var numero = new Numero(13);

            var valete = new CartaDoBaralho("Valete", Naipe.Copas); // construtor

            var numero2Espadas = new CartaDoBaralho(2, Naipe.Espadas);
            
            Console.WriteLine(valete);
            Console.WriteLine(numero2Espadas);


            
        }
    }
}
