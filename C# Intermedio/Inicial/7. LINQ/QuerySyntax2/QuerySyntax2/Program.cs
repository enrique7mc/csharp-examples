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
            
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var element in enumerable)
                Console.Write(" {0}", element);
        }
    }
}
