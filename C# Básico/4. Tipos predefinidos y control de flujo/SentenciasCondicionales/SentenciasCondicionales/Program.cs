using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SentenciasCondicionales
{
    /// <summary>
    /// Sentencias condicionales
    /// If
    /// If - Else
    /// Switch
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // If
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }


            // Condicional compuesta
            string user = "user1";
            string pass = "hola123";
            if (user == "user1" && pass == "hola123")
            {
                Console.WriteLine("Acceso correcto");
            }

            // If - Else
            int edad = 23;
            if (edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }        
    
            // If - Else If
            int a = 5;
            int b = 6;
            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);
            }

            // Switch
            // Funciona con cadenas o enteros
            string codigo = "A1";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Código A1");
                    break;
                case "B2":
                    Console.WriteLine("Código B2");
                    break;
                case "C8":
                    Console.WriteLine("Código C8");
                    break;
                default:
                    Console.WriteLine("Código no soportado");
                    break;
            }
        }
    }
}
