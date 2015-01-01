using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposReferenciaVsTiposValor
{
    /// <summary>
    /// Tipos de referencia Vs Tipos de valor
    /// Hay dos tipos de variables en C#: tipos de referencia y tipos de valor,
    /// los tipos de referencia almacenan referencias a un dato (objetos), mientras los
    /// tipos de valor contienen directamente un dato. Con los tipos de referencia, dos
    /// variables se pueden referir al mismo objeto, por lo tanto operaciones sobre una
    /// variable pueden afectar el objeto referido por otra variable.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* Tipo de valor */
            Console.WriteLine("Tipos de valor");
            // Crear un punto con valores iniciales
            PuntoVal puntoV = new PuntoVal(5, 10);
            // asignar el punto creado a otra variable llamada otroPunto
            // Como es un tipo de valor esta operación hace una copia
            PuntoVal otroPunto = puntoV;

            // Modificaciones en otroPunto no afectan al punto original
            otroPunto.X = 100;
            otroPunto.Y = 60;
            // Verificamos los valores
            Console.WriteLine("punto: ({0},{1})", puntoV.X, puntoV.Y);
            Console.WriteLine("otroPunto: ({0},{1})", otroPunto.X, otroPunto.Y);

            /* Tipo de referencia */
            Console.WriteLine("\nTipos de referencia");
            PuntoRef puntoR = new PuntoRef(5, 10);
            // asignar el punto creado a otra variable llamada segundoPunto
            // Como es un tipo de referencia ahora hay dos referencias apuntando al mismo objeto
            PuntoRef segundoPunto = puntoR;

            // Modificaciones en cualquier referencia modifican al objeto
            segundoPunto.X = 200;
            segundoPunto.Y = 300;
            // Verificamos el cambio
            Console.WriteLine("punto: ({0},{1})", puntoR.X, puntoR.Y);
            Console.WriteLine("otroPunto: ({0},{1})", segundoPunto.X, segundoPunto.Y);
        }
    }    
}
