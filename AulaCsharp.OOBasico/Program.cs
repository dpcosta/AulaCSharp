using System;

namespace AulaCsharp.OOBasico
{
    class Funcionario
    {
        public string Nome { get; } // propriedade
        public double Salario { get; protected set; }
        public int Matricula { get; set; }
        public DateTime Admissao { get; set; }
        public string Cargo { get; set; }

        // construtor:
        public Funcionario(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
                Nome = nome;
        }

        public Funcionario(int matricula)
        {
            Matricula = matricula;
        }

        //get (leitura) e set (escrita)

        public virtual void FazAniversarioDeEmpresa()
        {
            Salario = Salario * 1.1;
        }

        public void RecebeAumento(double quanto)
        {
            if (quanto > Salario)
                Salario = Salario + quanto;
        }

        public void MudaCargo(double novoSalario)
        {
            if (novoSalario > 0)
                Salario = novoSalario;
        }

        public virtual double Bonus
        {
            get
            {
                return Salario * 0.1;
            }
        }
    }

    class Gerente : Funcionario // gerente É UM funcionário
    {
        // herda propriedades e métodos
        // não herda construtores

        public Gerente(string nome) : base(nome) 
        {
            
        }

        public Gerente(int mat) : base(mat)
        {

        }

        public override double Bonus
        {
            get
            {
                return Salario * 0.2;
            }
        }

        public override void FazAniversarioDeEmpresa()
        {
            Salario = Salario * 1.2;
        }
    }

    class Engenheiro : Funcionario
    {
        public Engenheiro(string nome) : base(nome)
        {

        }
    }



    class Program // consumidor de funcionário
    {
        static void Main(string[] args)
        {
            Funcionario bruna = new Funcionario("Bruna")
            // initializer
            {
                Matricula = 1209,
                Admissao = new DateTime(2008, 12, 30)
            };
            
            bruna.MudaCargo(5000);

            Console.WriteLine(bruna.Nome);

            bruna.MudaCargo(6000);
            Console.WriteLine(bruna.Salario);
            
            bruna.FazAniversarioDeEmpresa();
            Console.WriteLine(bruna.Salario);

            bruna.RecebeAumento(120);
            Console.WriteLine(bruna.Salario);

            Console.WriteLine(bruna.Bonus);


            Gerente g = new Gerente("Flavia");
            g.MudaCargo(1000);
            Console.WriteLine(g.Bonus);

            //Console.WriteLine(admissao.ToString("dd/MM/yy"));

            //admissao.AddMonths(3);

            //Console.WriteLine(admissao.ToString("dd/MM/yyyy"));

            //DateTime hoje = DateTime.Today;
            //Console.WriteLine(hoje.ToString("dd/MM/yyyy"));

            //string aniversario = "25/04/1974";


            //que conceito é esse?

            string mat = "Daniel"; //argumento
            
            string matricula = mat;




        }
    }
}
