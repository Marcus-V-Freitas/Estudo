using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {

        public class CalculadoraEstatica
        {
            //Método de Classe ou Método Estático
            public static int Somar(int a, int b)
            {
                return a + b;
            }

            //Método de Instância
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }



        public static void Executar()
        {
            CalculadoraEstatica calc = new CalculadoraEstatica();
            int resultado = calc.Multiplicar(2, 2);
            Console.WriteLine(resultado);
            resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine(resultado);

        }
    }
}
