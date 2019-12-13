﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);

            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos" +intervalo.Minutes);

            Console.WriteLine("Intervalo em minutos", intervalo.TotalMinutes);


            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine(tempo.GetType().Name);

            Console.WriteLine(tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine(intervalo.ToString("g"));
            Console.WriteLine(intervalo.ToString("G"));
            Console.WriteLine(intervalo.ToString("c"));

            Console.WriteLine(TimeSpan.Parse("01:02:03").TotalMilliseconds);

        }
    }
}
