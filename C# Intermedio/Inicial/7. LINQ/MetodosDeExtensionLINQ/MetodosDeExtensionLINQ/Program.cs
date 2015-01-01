using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeExtensionLINQ
{
    /// <summary>
    /// Usando métodos de extensión de LINQ (fluent syntax)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            // muestra valores originales
            Console.Write("Lista original:");
            ImprimeEnumerable(numeros);
            
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
                Console.Write(" {0}", element);
        }
    }
}
