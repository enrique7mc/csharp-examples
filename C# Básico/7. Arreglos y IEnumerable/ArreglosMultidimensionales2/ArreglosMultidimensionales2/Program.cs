using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidimensionales2
{
    /// <summary>
    /// Arreglos multidimensionales
    /// Ejemplo con matrices
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = {{1.1, 0.3}, {5.5, 8}};
            double[,] matrizB = {{6, -2.1}, {0, 10.5}};

            Console.WriteLine("Matriz A");
            MostrarMatriz(matrizA);
            Console.WriteLine("Matriz B");
            MostrarMatriz(matrizB);

            // declara la matriz que almacenará el resultado
            double[,] suma = new double[2,2];
            // Realiza la suma de matrices elemento por elemento
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = matrizA[i, j] + matrizB[i, j];
                }                
            }

            Console.WriteLine("A + B");
            MostrarMatriz(suma);
        }

        static void MostrarMatriz(double[,] matriz)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0:0.#0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
