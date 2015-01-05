using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArray
{
    /// <summary>
    /// La clase Array proporciona métodos útiles
    /// para trabajar con arreglos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];

            // Genera una copia del arreglo
            Array.Copy(list, temp, list.Length);

            Console.Write("Arreglo Original: ");
            MostrarArreglo(list);

            // invierte el arreglo
            Array.Reverse(temp);
            Console.Write("Arreglo Invertido: ");
            MostrarArreglo(temp);

            // ordena el arreglo
            Array.Sort(list);
            Console.Write("Arreglo Ordenado: ");
            MostrarArreglo(list);
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int i in arreglo)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
