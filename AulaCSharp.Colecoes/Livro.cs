using System;
using System.Collections.Generic;
using System.Text;

namespace AulaCSharp.Colecoes
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int TotalPaginas { get; set; }

        public override string ToString()
        {
            return this.Titulo;
        }

        public override bool Equals(object obj)
        {
            Livro outro = obj as Livro;
            return this.Titulo == outro.Titulo;
        }

        public override int GetHashCode()
        {
            return 122987 + this.Titulo.GetHashCode();
        }
    }
}
