using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action AlgoConsole = () =>
            { Console.WriteLine("Lambda com C#"); };


            AlgoConsole();

            Action<String> Imprimir = (a) => Console.WriteLine($"Testando"+a);

            Func<int> JogarDados = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };


            Imprimir("!!!");

            Console.WriteLine(JogarDados());

            Func<int, string> ConversorHex = (numero) => numero.ToString("X");
            Console.WriteLine(ConversorHex(12345));

            Func<int, int, int, string> FormatarData = (dia, mes, ano) => string.Format($"{dia:D2}/{mes:D2}/{ano:D4}");
            Console.WriteLine(FormatarData(1,1,2019));
        }
    }
}
