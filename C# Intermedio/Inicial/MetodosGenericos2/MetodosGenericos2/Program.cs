using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosGenericos2
{
    /// <summary>
    /// Otro ejemplo con métodos genéricos, este método regresa
    /// el mayor de tres objetos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
                3, 4, 5, Mayor(3, 4, 5));

            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               6.6, 8.8, 7.7, Mayor(6.6, 8.8, 7.7));

            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               "pera", "manzana", "naranja", Mayor("pera", "manzana", "naranja"));
        }

        private static T Mayor<T>(T x, T y, T z)
        {
            // método no implementado
            throw new NotImplementedException();  
        }
    }
}
