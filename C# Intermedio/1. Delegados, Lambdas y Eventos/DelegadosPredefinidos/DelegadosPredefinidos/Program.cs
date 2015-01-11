using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredefinidos
{
    /// <summary>
    /// Delegados predefinidos en .NET
    /// Action<T>, Func<T>, Predicate<T>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Action es un delegado que puede recibir parámetros
            // y no tiene retorno (void)

            // Delegado que recibe una cadena
            Action<string> mostrar = s => Console.WriteLine(s);
            mostrar("Usando Action<T>");

            // Delegado que recibe dos enteros
            Action<int, int> suma = (x, y) => Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            suma(15, 2);

            // Func es un delegado que puede recibir parámetros
            // y puede devolver cualquier un tipo de dato

            // Delegado que recibe un entero y devuelve un entero
            Func<int, int> cubo = n => n * n * n;
            int num = 5;
            Console.WriteLine("Cubo de {0} es {1}", num, cubo(num));

            // Delegado que recibe una cadena y devuelve una cadena
            Func<string, string> saludo = nombre => "Hola " + nombre;
            Console.WriteLine(saludo("Enrique"));

            // Predicate es un delegado que puede recibir parámetos
            // y tiene tipo de retorno bool
            Predicate<int> mayorQue0 = n => n > 0;
            Console.WriteLine("{0} es mayor que 0?: {1}", num, mayorQue0(num));

            Predicate<string> empiezaConE = str => str.StartsWith("E");
            string cadena = "Hola";
            Console.WriteLine("{0} empieza con E?: {1}", cadena, empiezaConE(cadena));
        }
    }
}
