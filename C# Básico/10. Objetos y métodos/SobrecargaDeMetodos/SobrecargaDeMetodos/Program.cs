using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SobrecargaDeMetodos
{
    /// <summary>
    /// Sobrecarga de métodos
    /// La sobrecarga ocurre cuando dos métodos tiene el mismo nombre pero
    /// diferentes firmas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Metodo(10);
            Metodo("hello");
            Metodo(0, 0);
        }

        static void Metodo(int x)
        {
            Console.WriteLine("Metodo(int x)");
        }

        static void Metodo(string y)
        {
            Console.WriteLine("Metodo(string y)");
        }

        static void Metodo(double x, int y)
        {
            Console.WriteLine("Metodo(double x, int y)");
        }
    }
}
