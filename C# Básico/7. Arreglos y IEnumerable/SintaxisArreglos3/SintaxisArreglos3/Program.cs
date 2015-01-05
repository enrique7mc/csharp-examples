using System;

namespace SintaxisArreglos3
{
    /// <summary>
    /// Sintaxis y uso de arreglos
    /// Leer y mostrar datos de un arreglo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Tamaño del arreglo: ");
            int tam = Convert.ToInt32(Console.ReadLine());

            // definir arreglo
            // el arreglo por default se inicializa con 0
            int[] numeros = new int[tam];
            
            // leer datos y guardarlos en el arreglo
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escribe índice {0}: ", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Muestra los datos
            Console.WriteLine("Los datos que ingresaste son");
            MostrarArreglo(numeros);
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach(int num in arreglo)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
