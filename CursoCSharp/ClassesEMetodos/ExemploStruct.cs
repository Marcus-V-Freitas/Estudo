using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploStruct
    {

        interface Ponto
        {
            void MoverDiagonal(int delta);
        }

        struct Coordenada : Ponto
        {
            public int X;
            public int Y;

            public Coordenada(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void MoverDiagonal(int delta)
            {
                X += delta;
                Y += delta;
            }
        }

        public static void Executar()
        {
            Coordenada CoordenadaInicial;
            CoordenadaInicial.X = 2;
            CoordenadaInicial.Y = 2;
            Console.WriteLine(CoordenadaInicial.X);
            Console.WriteLine(CoordenadaInicial.Y);

            var CoordenadaFinal = new Coordenada(9, 1);
            CoordenadaFinal.MoverDiagonal(10);
            Console.WriteLine(CoordenadaFinal.X);
            Console.WriteLine(CoordenadaFinal.Y);
        }
    }
}
