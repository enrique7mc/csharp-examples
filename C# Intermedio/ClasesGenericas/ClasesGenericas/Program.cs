using System;
using System.Linq;
using System.Text;

namespace ClasesGenericas
{
    /// <summary>
    ///  Ejemplo con clase genérica
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>();
            stack.Push(5.5);
            stack.Push(10.1);

            double x = stack.Pop(); 
            double y = stack.Pop(); 

            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
}
