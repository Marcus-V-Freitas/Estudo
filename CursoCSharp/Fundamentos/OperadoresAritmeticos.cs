
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço com Desconto

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine($"O valor final é de {totalDesconto}");

            //IMC

            double peso = 70.0;
            double altura = 1.73;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC é  {imc.ToString("#.##")}");

            //Números Par/Impar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2);




        }
    }
}
