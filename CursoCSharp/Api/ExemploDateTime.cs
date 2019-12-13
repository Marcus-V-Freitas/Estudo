using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2020, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Sem Horas

            var hoje = DateTime.Today;

            //Com Horas

            var DiaAtual = DateTime.Now;

            //Acessar somente horas

            Console.WriteLine(DiaAtual.Hour);

            //Acessar somente minutos

            Console.WriteLine(DiaAtual.Minute);

            var amanha = DiaAtual.AddDays(1);
            var ontem = DiaAtual.AddDays(-1);

            Console.WriteLine(DiaAtual.ToString("dd"));
            Console.WriteLine(DiaAtual.ToString("d"));
            Console.WriteLine(DiaAtual.ToString("D"));
            Console.WriteLine(DiaAtual.ToString("g"));
            Console.WriteLine(DiaAtual.ToString("G"));
            Console.WriteLine(DiaAtual.ToString("dd-MM-yyyy HH:mm"));





        }
    }
}
