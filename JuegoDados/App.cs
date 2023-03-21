using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDados
{
    public class App
    
    {
        public void Aplicacion()
        {
            
            Juego juego = new Juego();
            Console.WriteLine("¡¡Bienvenido al juego de los dados!!");
         
            juego.buscarCoincidencia();
            juego.Preguntar();
      
        }

    }
}
