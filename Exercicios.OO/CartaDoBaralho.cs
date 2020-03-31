using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.OO
{
    enum Naipe
    {
        Espadas,
        Copas,
        Ouros,
        Paus
    }

    struct Numero // qq tipo de aplicação!! 
    {
        public Numero(int num)
        {
            if (num < 2 || num > 10)
            {
                // exceção
                throw new Exception("Número de carta inválido");
            }
        }
    }

    class CartaDoBaralho : Object // herda diretamente de object
    {
        public Naipe Naipe { get; set; }
        public int Numero { get; set; }
        public string Figura { get; set; }

        // sobrecarga de construtor; distinção é feita pela qtde argumentos, tipo arg

        public CartaDoBaralho(string figura, Naipe naipe)
        {
            Figura = figura;
            Naipe = naipe;
        }

        public CartaDoBaralho(int numero, Naipe naipe)
        {
            Numero = numero;
            Naipe = naipe;
        }

        public override string ToString()
        {
            if (Numero == 0) return Figura + " de " + Naipe;
            return Numero + " de " + Naipe;
        }
    }
}
