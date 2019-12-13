using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorprivado;

        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            this.Coisa = coisa;
            valorprivado = coisa;
        }

        public T MetodoPrivado(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorprivado;
        }
    }


    public class CaixaInt : Caixa<int>
    {
       public CaixaInt() : base(0) { }
    }

    public class CaixaProduto : Caixa<Produto>
    {
       public CaixaProduto():base(new Produto()) { }
    }


    class Genericos
    {
        public static void Executar()
        {
            var Caixa1 = new Caixa<int>(1000);
            Console.WriteLine(Caixa1.MetodoPrivado(33));
            Console.WriteLine(Caixa1.Coisa.GetType());


            var Caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(Caixa2.MetodoPrivado("Metodo"));
            Console.WriteLine(Caixa2.Coisa.GetType());

            CaixaProduto Caixa3 = new CaixaProduto();
            Console.WriteLine(Caixa3.Coisa.GetType().Name);

        }
    }
}
