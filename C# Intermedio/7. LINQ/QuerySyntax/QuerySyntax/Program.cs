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

            // muestra valores originales
            Console.Write("Arreglo original:");
            ImprimeEnumerable(numeros);
            
            // query que obtiene numeros mayores que 4 del arreglo
            var filtered =
               from   n in numeros
               where  n > 4
               select n;

            // muestra los resultados filtrados
            Console.Write("\nNúmeros mayores que 4:");
            ImprimeEnumerable(filtered);

            // la cláusula order by ordena los valores originales en orden ascendente            
            var sorted =
               from    n in numeros
               orderby n
               select  n;

            // muestra los resultados ordenados
            Console.Write("\nArreglo original, ordenado:");
            ImprimeEnumerable(sorted);

            // ordena los resultados filtrados en orden descendente            
            var sortFilteredResults =
               from    n in filtered
               orderby n descending
               select  n;

            // muestra los resultados filtrados y ordenados
            Console.Write(
               "\nNúmeros mayores que 4, orden descendente (por separado):");
            ImprimeEnumerable(sortFilteredResults);

            // filtra el arreglo original y ordena los resultados (desc)            
            var sortAndFilter =
               from    n in numeros
               where   n > 4
               orderby n descending
               select  n;

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
