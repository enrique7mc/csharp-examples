using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace OtroMetodos
{
    /// <summary>
    /// Otros métodos comunes de LINQ
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = { 72.0, 81.5, 69.3, 88.6, 80.0, 68.5 };

            double promedio = temperaturas.Average();
            Console.WriteLine("Promedio: {0}", promedio);

            int mayores80 = temperaturas.Count(t => t > 80);
            Console.WriteLine("Mayores de 80°: {0}", mayores80);

            double maxima = temperaturas.Max();
            Console.WriteLine("Máxima: {0}", maxima);

            double minima = temperaturas.Min();
            Console.WriteLine("Mínima: {0}", minima);

            double suma = temperaturas.Sum();
            Console.WriteLine("Mínima: {0}", suma);

            double primero = temperaturas.First();
            Console.WriteLine("Primero: {0}", primero);

            double ultimo = temperaturas.Last();
            Console.WriteLine("Último: {0}", ultimo);

            var skip = temperaturas.Skip(3);
            Console.Write("Omite los primeros 3: ");
            ImprimeEnumerable(skip);

            var take = temperaturas.Take(5);
            Console.Write("Toma los primeros 5: ");
            ImprimeEnumerable(take);
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> datos)
        {
            foreach (var dato in datos)
            {
                Console.Write(" {0}", dato);
            }
            Console.WriteLine();
        }
    }
}
