using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuerySyntax2
{
    /// <summary>
    /// Ejemplo de Query Syntax con colección de cadenas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] paises = { "México", "Canadá", "Argentina", "Cuba", "Rusia" };

            // países cuyo nombre contiene a, ordenados por logitud
            IEnumerable<string> query =
                from p in paises
                where p.Contains("a") // Filtra los elementos
                orderby p.Length // los ordena 
                select p.ToUpper(); // los transforma

            ImprimeEnumerable(query);
            Console.WriteLine();

            // países cuyo nombre tiene tamaño mayor a 5, ordenados por nombre
            IEnumerable<string>  query2 =
                from p in paises
                where p.Length > 5
                orderby p
                select p;

            ImprimeEnumerable(query2);
            Console.WriteLine();

            // iniciales de los paises ordenados por longitud descendente
            IEnumerable<char> query3 =
                from p in paises
                orderby p.Length descending
                select p[0];

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
