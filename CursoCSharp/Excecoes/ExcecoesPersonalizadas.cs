using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{

    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception Inner): base(message, Inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException() { }
        public ImparException(string message) : base(message) { }
        public ImparException(string message, Exception Inner) : base(message, Inner) { }
    }
   
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Número Negativo");
            }
            if (valor % 2 == 1)
            {
                throw new ImparException("Número Impar");
            }
            return valor;
        }

        public static void Executar()
        {
        
            try
            {
                Console.WriteLine(PositivoPar());
            }catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
