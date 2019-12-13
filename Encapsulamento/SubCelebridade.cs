using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos tem acesso
        public string InfoPublica = "Tenho Instagram!";

        //Herança
        protected string CorDosOlhos = "Verde";

        //Mesmo projeto (Assembly)
        internal ulong NumeroTelefone = 55959121570;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //Mesma classe ou herançsa no mesmo projeto (Disponivel somente em versoes C#>=7.2)
        private protected string SegredoDeFamilia = "Bla Bla";

        //Private é o padrão
        bool UsaMuitoPhotoShop = true;

        public void MeuAcesso()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroTelefone);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoShop);
        }


    }
}
