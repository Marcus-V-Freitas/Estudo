using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string marca;
        private string modelo;
        private uint cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            //this.marca = marca;
            //this.modelo = modelo;
            //this.cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { }

        public string GetMarca()
        {
            return marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public uint GetCilindrada()
        {
            return cilindrada;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void SetCilindrada(uint cilindrada)
        {
            //1 Opção (Int) Uso estrutura de condição
            //if (cilindrada > 0)
            //{
            //    this.cilindrada = cilindrada;
            //}

            //2 Opção (Int) Uso do Math.Abs
            //this.cilindrada = Math.Abs(cilindrada);

            //3 Opção - Uso do Uint
            this.cilindrada = cilindrada;
        }


    }




    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-65", 636);
            Console.WriteLine($"{moto1.GetMarca()} {moto1.GetModelo()} {moto1.GetCilindrada()}");

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
        }
    }
}
