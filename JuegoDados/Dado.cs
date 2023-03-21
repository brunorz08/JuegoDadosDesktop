using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDados
{
    public class Dado
    {
        private int valor;
        public int valorMinimo;
        public int valorMaximo;
        private Random aleatorio = new Random();

       

        public void tirar()
        {
            valor = aleatorio.Next(valorMinimo, valorMaximo);
        }

        public void Imprimir()
        {
            Console.WriteLine($"Valor:{valor}");
        }

        public int retonarValor()
        {
            return valor;
        }
    }
}
