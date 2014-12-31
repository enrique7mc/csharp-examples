using System;
using System.Collections.Generic;
using System.Linq;

namespace QuerySyntax
{
    /// <summary>
    /// LINQ Query syntax
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un arreglo de enteros
            int[] numeros = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
            
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
                Console.Write(" {0}", element);
        }
    }
}
