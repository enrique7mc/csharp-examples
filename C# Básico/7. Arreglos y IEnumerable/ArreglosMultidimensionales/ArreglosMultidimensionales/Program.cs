using System;

namespace ArreglosMultidimensionales
{
    /// <summary>
    /// Arreglos multidimensionales
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // declara un arreglo con 3 filas y dos columnas            
            int[,] a = new int[3, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 } };            

            // Muestra el arreglo con un ciclo for anidado            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }

            int[,] matriz = new int[2, 2] { { 5, 1 }, { 2, 4 } };
            Console.WriteLine("Muestra el arreglo en forma de matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

            // declara una arreglo de 10 x 8 inicializado en 0
            int[,] arreglo = new int[10, 8];
        }
    }
}
