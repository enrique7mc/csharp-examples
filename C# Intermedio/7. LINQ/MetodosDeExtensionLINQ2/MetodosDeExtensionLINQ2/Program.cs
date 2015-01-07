using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeExtensionLINQ2
{
    /// <summary>
    /// Ejemplo de métodos de extensión LINQ con colección de cadenas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] paises = { "México", "Canadá", "Argentina", "Cuba", "Rusia" };

            // países cuyo nombre contiene a, ordenados por logitud
            IEnumerable<string> query = paises.Where(p => p.Contains("a")) // Filtra los elementos
                                              .OrderBy(p => p.Length)      // los ordena 
                                              .Select(p => p.ToUpper());   // los transforma

            ImprimeEnumerable(query);
            Console.WriteLine();

            // países cuyo nombre tiene tamaño mayor a 5, ordenados por nombre
            IEnumerable<string> query2 = paises.Where(p => p.Length > 5)
                                               .OrderBy(p => p);

            ImprimeEnumerable(query2);
            Console.WriteLine();

            // iniciales de los paises ordenados por longitud descendente
            IEnumerable<char> query3 = paises.OrderByDescending(p => p.Length)
                                             .Select(p => p[0]);                

            ImprimeEnumerable(query3);
            Console.WriteLine();
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
                Console.Write(" {0}", element);
        }
    }
}
