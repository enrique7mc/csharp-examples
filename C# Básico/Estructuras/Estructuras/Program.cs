using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuras
{
    /// <summary>
    /// Estructuras
    /// Un tipo struct es un tipo de valor que normalmente se usa para encapsular pequeños grupos de variables relacionadas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);

            Console.WriteLine("Módulo vector 1: " + v1.CalcularModulo());
            Console.WriteLine("Módulo vector 2: " + v2.CalcularModulo());

            Vector resultado = v1.Suma(v2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(resultado);
        }
    }
}
