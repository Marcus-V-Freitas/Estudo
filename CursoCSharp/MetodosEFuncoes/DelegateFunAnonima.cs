using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            StringOperacao Inverter = delegate (string s)
              {
                  char[] charArray = s.ToCharArray();
                  Array.Reverse(charArray);
                  return new string(charArray);
              };
            Console.WriteLine(Inverter("C# é show!!!"));
        }
    }
}
