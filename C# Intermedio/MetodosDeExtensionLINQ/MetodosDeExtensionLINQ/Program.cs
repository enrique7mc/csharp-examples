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

            var filtered = numeros.Where(n => n > 4);

            // muestra los resultados filtrados
            Console.Write("\nNúmeros mayores que 4:");
            ImprimeEnumerable(filtered);

            // la cláusula order by ordena los valores originales en orden ascendente            
            var sorted = numeros.OrderBy(n => n);

            // muestra los resultados ordenados
            Console.Write("\Lista original, ordenada:");
            ImprimeEnumerable(sorted);

            // ordena los resultados filtrados en orden descendente            
            var sortFilteredResults = filtered.OrderByDescending(n => n);

            // muestra los resultados filtrados y ordenados
            Console.Write(
               "\nNúmeros mayores que 4, orden descendente (por separado):");
            ImprimeEnumerable(sortFilteredResults);

            // filtra la lista original y ordena los resultados (desc)            
            var sortAndFilter = numeros.Where(n => n > 4)
                                       .OrderByDescending(n => n);

            // muestra los resultados filtrados y ordenados
            Console.Write(
               "\nNúmeros mayores que 4, orden descendente (una sola consulta):");
            ImprimeEnumerable(sortAndFilter);

            Console.WriteLine();
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
                Console.Write(" {0}", element);
        }
    }
}
