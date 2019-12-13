using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area da CircunferÊncia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            //PI não pode ser alterado por ser constante

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + (area + 1000));

            //Tipos internos 

            //Inteiros

            bool chovendo = true;
            Console.WriteLine("Está chovendo? " + chovendo);

            //Byte Sem sinal

            byte idade = 45;
            Console.WriteLine("A idade é: " + idade);

            //Byte Com Sinal

            sbyte Saldo = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + Saldo);

            short Salario = short.MaxValue;
            Console.WriteLine("O salario é" + Salario);

            //Int Com Sinal

            int menorvalor = int.MinValue;
            Console.WriteLine("Menor valor de int é: " + menorvalor);

            //Int Sem sinal

            uint populacao = 207_600_000;
            Console.WriteLine("A populacao é de " + populacao);

            //Long com sinal

            long menorvalorlong = long.MinValue;
            Console.WriteLine("O menor valor do long " + menorvalorlong);
            
            //Long sem sinal

            ulong maiorvalorlong = ulong.MaxValue;
            Console.WriteLine("O menor valor do long " + maiorvalorlong);

            //Reais
            double maiorvalordouble = double.MaxValue;
            Console.WriteLine("O menor valor do double " + maiorvalordouble);

            Decimal maiorvalordecimal = Decimal.MaxValue;
            Console.WriteLine("O menor valor do Decimal " + maiorvalordecimal);

            char letra = 'd';
            Console.WriteLine(letra);

            string texto = "texto";
            Console.WriteLine(texto);


        }
    }
}

