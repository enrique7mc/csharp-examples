using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEstaticas
{
    /// <summary>
    /// Clases estáticas y métodos de extensión
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el tipo de conversión");
            Console.WriteLine("1. Celsius a Fahrenheit.");
            Console.WriteLine("2. Fahrenheit a Celsius.");
            Console.Write(":");

            // Leer datos desde el teclado
            string selection = Console.ReadLine();
            double F, C = 0;
            string dato;

            switch (selection)
            {
                case "1":
                    Console.Write("Ingresa la temperatura en Celsius: ");
                    dato = Console.ReadLine();
                    // Usando el método estático de forma normal
                    F = ConversorTemperatura.CelsiusToFahrenheit(dato);
                    // Muestra el resultado como flotante de dos decimales
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Ingresa la temperatura en Fahrenheit: ");
                    dato = Console.ReadLine();
                    // Usando el método estático como método de extensión
                    C = dato.FahrenheitToCelsius();
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
