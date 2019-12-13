using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //Implicito
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Explicito com Cast
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"{notaTruncada}");

            //Explicito com Parse
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"A idade inserida foi: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"{idadeInteiro}");

            //Explicito Seguro com TryParse

            Console.WriteLine("Digite o 1 número");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine(numero1);

            //Explicito Seguro com TryParse otimizado

            Console.WriteLine("Digite o 2 número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);




        }
    }
}
