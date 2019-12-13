using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeuAcesso()
        {
            Console.WriteLine("Amigo Proximo...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorOlhos);
            Console.WriteLine(amiga.NumeroTelefone);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoShop);
        }
    }
}
