using System;
using System.Collections.Generic;
using System.Text;
using JuegoDados;
using static System.Net.Mime.MediaTypeNames;

namespace JuegoDados
{
    public class Juego
    {

        public Dado Dado1 = new Dado();
        public Dado Dado2 = new Dado();
        public Dado Dado3 = new Dado();
        App Aplicacion = new App();
    
        
    
    
        public void buscarCoincidencia()
        {
            int contador = 0;
            int intentos;

            Console.Write("Ingrese numero de intentos: ");
            intentos = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese valor minimo de los dados: ");
            Dado1.valorMinimo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese valor maximo de los dados: ");
            Dado1.valorMaximo = Convert.ToInt32(Console.ReadLine());

            Dado2.valorMinimo = Dado1.valorMinimo;
            Dado2.valorMaximo = Dado1.valorMaximo;
            Dado3.valorMinimo = Dado1.valorMinimo;
            Dado3.valorMaximo = Dado1.valorMaximo;


            for (int i = 0; i < intentos; i++)
            {
                Dado1.tirar();
                Dado2.tirar();
                Dado3.tirar();

                Console.WriteLine($"Dado 1:{Dado1.retonarValor()}");
                Console.WriteLine($"Dado 2:{Dado2.retonarValor()}");
                Console.WriteLine($"Dado 3:{Dado3.retonarValor()}");

                contador++;


                if (Dado1.retonarValor() == Dado2.retonarValor() && Dado1.retonarValor() == Dado3.retonarValor())
                {
                    Console.WriteLine("Coincidencia!!");

                    Console.WriteLine($"Se necesitaron {contador} intentos");
                    break;
                }
                else
                {
                    Console.WriteLine("No hay coincidencias");
                }
            }
        }


        public void Preguntar()
        {

            Console.WriteLine("¿Desea volver a jugar? Presione 1 para SI o 2 para NO");


            string opcion = Console.ReadLine();
            Console.Clear();
            if (opcion == "1")
            {
                Aplicacion.Aplicacion();

            }
            else if (opcion == "2")
            {
                Console.WriteLine("Gracias por jugar");
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
                Preguntar();
            }


        }


    }
}
