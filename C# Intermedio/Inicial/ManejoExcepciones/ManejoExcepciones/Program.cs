using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManejoExcepciones
{
    /// <summary>
    /// Ejemplo de manejo de excepciones
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el numerador: ");
            int numerador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el denominador: ");
            int denominador = Convert.ToInt32(Console.ReadLine());

            // realiza la división y muestra el resultado
            int resultado = numerador / denominador;
            Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}",
               numerador, denominador, resultado);
        }
    }
}
