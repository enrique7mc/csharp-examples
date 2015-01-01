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
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);

            int x = stack.Pop(); 
            int y = stack.Pop(); 

            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
}
