using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        protected double peso;

        public double GetPeso() {
            return peso; }
            public void SetPeso(double Peso){
            peso += Peso;
        }

        public Comida(double peso)
        {
            this.peso = peso;
        }

        public Comida() { }
    }

    public class Feijao:Comida
    {

    }

    public class Arroz : Comida
    {

    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa
    {
        public double peso;
        /*
         *Em vez de:
         * public void Comer Arroz(Arroz arroz)
         * {
         * peso+=arroz;
         * }
         * 
         *  public void Comer Feijao(Feijao feijao)
         * {
         * peso+=feijao;
         * }
         * 
         *  public void Comer Carne(Carne carne)
         * {
         * peso+=carne;
         * }
         * */

            //Faça polimorfismo (Tudo é comida)

        public void Comer(Comida comida)
        {
            peso += comida.GetPeso();
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Arroz ingrediente1 = new Arroz();
            ingrediente1.SetPeso(0.3);
            Feijao ingrediente2 = new Feijao();
            ingrediente2.SetPeso(0.25);
            Carne ingrediente3 = new Carne(0.3);
            Pessoa cliente = new Pessoa();
            cliente.peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            Console.WriteLine($"O cliente pesa agora {cliente.peso}Kg.");
        }
    }
}
