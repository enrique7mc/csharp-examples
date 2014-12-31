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
            try
            {
                // Convert.ToInt32 genera FormatException                 
                // si el argumento no puede ser convertido a entero
                Console.Write("Ingresa el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                // la división genera DivideByZeroException                  
                // si el denominador es 0 
                int resultado = numerador / denominador;
                Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}",
                   numerador, denominador, resultado);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar dos enteros.");
            }                                               
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("\n" + divideByZeroException.Message);
                Console.WriteLine("Cero es un denominador inválido.");
            }
        }
    }
}
