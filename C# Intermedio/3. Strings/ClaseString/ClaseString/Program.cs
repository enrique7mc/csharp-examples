using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseString
{
    /// <summary>
    /// Métodos de la clase string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenación de cadenas
            Console.WriteLine("Hola " + "mundo");
            Console.WriteLine(string.Concat("Hola ", "mundo"));

            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);
            Console.WriteLine("Mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("Minúsculas: " + cadena.ToLower());
            // Uso de Replace para quitar espacios
            Console.WriteLine("Replace: " + cadena.Replace(" ", ""));
            Console.WriteLine("Carácter en índice 0: " + cadena[0]);
            Console.WriteLine("Carácter en índice 1: " + cadena[1]);
            // Subcadena de 8 caracteres a partir del índice 1
            Console.WriteLine("Substring (1-8): " + cadena.Substring(1, 8)); 
            // Verificar si una cadena contiene a otra
            Console.WriteLine("cadena contiene \"es\"? " + cadena.Contains("es"));
            // Verificar si una cadena empieza con otra
            Console.WriteLine("cadena empieza con \"La\"? " + cadena.StartsWith("La"));
            // Verificar si una cadena es nula o vacía
            string nula = null;
            Console.WriteLine("nula es null? " + string.IsNullOrEmpty(nula));
            Console.WriteLine("cadena es null? " + string.IsNullOrEmpty(cadena));
            // Obtiene la posición de un dato
            Console.WriteLine("Posición de la cadena \"de\": " + cadena.IndexOf("de"));
        }
    }
}
