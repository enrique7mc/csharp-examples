using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisArreglos2
{
    /// <summary>
    /// Sintaxis y uso de arreglos
    /// Iterar arreglos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = {10, 9, 30, -4, 0, 2, 11};

            Console.WriteLine("Iterar arreglo con ciclo for");            
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("{0} ", arreglo[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Iterar arreglo con ciclo for each");
            foreach(int num in arreglo)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();

            string[] cadenas = {"hola", "mundo", "ciclos", "arreglos", "cadenas"};
            Console.WriteLine("Iterar arreglo con ciclo for (orden inverso)");
            for(int i = cadenas.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", cadenas[i]);
            }

            Console.WriteLine();
        }
    }
}
