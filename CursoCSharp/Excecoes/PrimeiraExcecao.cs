using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double saldo;

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public void Sacar (double valor)
        {
            if (valor > saldo)
            {
                throw new ArgumentException("Saldo Insuficiente.");
            }
            saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta1 = new Conta(1_233.54);
            try
            {
                //int.Parse("ABC");
                conta1.Sacar(1600);
                Console.WriteLine("Retirada com sucesso.");
                //}catch(ArgumentException ex)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
