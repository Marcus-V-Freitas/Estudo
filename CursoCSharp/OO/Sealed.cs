using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValordaFortuna()
        {
            return 1_407_033.65;
        }
    }
    //class SouFilho: SemFilho { }

   public class Avo
    {
        public virtual bool HonrarFamilia()
        {
            return true;
        }
    }

        public class Pai : Avo
        {
            public sealed override bool HonrarFamilia()
            {
                return true;
            }

        }

        public class FilhoRebelde : Pai
        {
            //public override bool HonrarFamilia()
            //{
            //    return false;
            //}

            //public new bool HonrarFamilia()
            //{
            //    return false;
            //}
        }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValordaFortuna());

            FilhoRebelde filhorebelde = new FilhoRebelde();
            Console.WriteLine(filhorebelde.HonrarFamilia());
        }
    }
}
