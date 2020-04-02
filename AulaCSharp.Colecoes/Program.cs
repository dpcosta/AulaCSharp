using System;
using System.Collections;
using System.Collections.Generic;

namespace AulaCSharp.Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // como colocar um tamanho ilimitado/genérico/dinâmico? Em arrays não dá!
            
            // serieNumerica: lista de int

            // frutas: lista de Fruta

            // biblioteca: lista de Livro (Generics)
            List<Livro> biblioteca = new List<Livro>();

            var livro1 = new Livro { Titulo = "C# OO" };

            biblioteca.Add(livro1);
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());
            biblioteca.Add(new Livro());

            Console.WriteLine(biblioteca.Count);


            //List >> acesso indexado, sequencial
            var indice = biblioteca.IndexOf(livro1);
            var livroQualquer = biblioteca[5];

            // percorrer
            for (int i = 0; i < biblioteca.Count; i++)
            {
                Livro l = biblioteca[i];
                Console.WriteLine(l.Titulo); 
            }

            foreach(Livro l in biblioteca)
            {
                Console.WriteLine(l.Titulo);
            }


            List<string> frutas = new List<string>();
            frutas.Add("banana");
            frutas.Add("maçã");
            frutas.Add("abacaxi");
            frutas.Add("banana");

            //4 elementos
            Console.WriteLine(frutas.Count);

            // Set: evita duplicação, chave é o HashCode
            HashSet<string> frutasDistintas = new HashSet<string>();
            frutasDistintas.Add("maçã");
            frutasDistintas.Add("banana");
            frutasDistintas.Add("abacaxi");
            frutasDistintas.Add("banana");

            //3 elementos
            Console.WriteLine(frutasDistintas.Count);


            HashSet<Livro> livros = new HashSet<Livro>();
            var livro2 = new Livro { Titulo = "ASP Avançado" };
            var livro3 = new Livro { Titulo = "SQL" };
            var livro4 = new Livro { Titulo = "SQL" };

            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);
            livros.Add(livro4);

            if (livro3.Equals(livro4))
            {
                Console.WriteLine("Iguais");
            } else
            {
                Console.WriteLine("Diferentes");
            }

            Console.WriteLine(livros.Count);

            // Mapa, Dicionário >> evita duplicação, chave é customizada

            Dictionary<string, Livro> mapa = new Dictionary<string, Livro>();
            mapa.Add(livro1.Titulo, livro1);
            mapa.Add(livro2.Titulo, livro2);
            mapa.Add(livro3.Titulo, livro3);
            mapa.Add(livro4.Titulo, livro4);

            Console.WriteLine(mapa.Count); //3

        }
    }
}
