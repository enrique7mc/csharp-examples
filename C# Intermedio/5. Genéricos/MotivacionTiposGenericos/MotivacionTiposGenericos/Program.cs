using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotivacionTiposGenericos
{
    /// <summary>
    /// Ejemplo de motivación para utilizar tipos genéricos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double y char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("intArray contiene:");
            MuestraArreglo(intArray);

            Console.WriteLine("doubleArray contiene:");
            MuestraArreglo(doubleArray);

            Console.WriteLine("charArray contiene:");
            MuestraArreglo(charArray); 
        }

        // muestra arreglo int
        private static void MuestraArreglo(int[] arreglo)
        {
            foreach (int element in arreglo)
                Console.Write(element + " ");

            Console.WriteLine("\n");
        }

        // muestra arreglo double
        private static void MuestraArreglo(double[] arreglo)
        {
            foreach (double element in arreglo)
                Console.Write(element + " ");

            Console.WriteLine("\n");
        }

        // muestra arreglo char
        private static void MuestraArreglo(char[] arreglo)
        {
            foreach (char element in arreglo)
                Console.Write(element + " ");

            Console.WriteLine("\n");
        }
    }
}
