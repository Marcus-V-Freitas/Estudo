using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeuAcesso()
        {
            Console.WriteLine("Filho Não Reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoShop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeuAcesso()
        {
            Console.WriteLine("Amigo Distante...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoShop);
        }
        
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            var sub = new SubCelebridade();
            sub.MeuAcesso();
            new FilhoReconhecido().MeuAcesso();
            new FilhoNaoReconhecido().MeuAcesso();
            new AmigoProximo().MeuAcesso();
            new AmigoDistante().MeuAcesso();
        }
    }
}
