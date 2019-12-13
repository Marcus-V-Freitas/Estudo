using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    interface Teste
    {
        bool bla(string a);
    }


    interface OperacaoBinaria //: Teste - Herda de outra interface e obriga outras classes a implementarem as duas interfaces
        {
        int Operacao(int a, int b);
}

    public class Somar: OperacaoBinaria, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool bla(string teste)
        {
            return true;
        }
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>()
        {
            new Somar(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach(var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}\n";

            }
            return resultado;
        }
    }


    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            Console.WriteLine(calc.ExecutarOperacoes(20, 5));
        }
    }
}
