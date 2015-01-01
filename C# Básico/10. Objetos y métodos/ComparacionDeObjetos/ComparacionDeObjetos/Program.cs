using System;

namespace ComparacionDeObjetos
{
    /// <summary>
    ///  Comparación de objetos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("John Doe", 31);
            Persona p2 = new Persona("John Doe", 31);
            Persona p3 = p1;

            // Comparación por referencia
            Console.Write("Referencias p1 y p2 son iguales: ");
            Console.WriteLine(p1 == p2);
            Console.Write("Referencias p2 y p3 son iguales: ");
            Console.WriteLine(p2 == p3);
            Console.Write("Referencias p1 y p3 son iguales: ");
            Console.WriteLine(p1 == p3);

            Console.WriteLine();

            // Comparación de objetos
            Console.Write("Objetos de p1 y p2 son iguales: ");
            Console.WriteLine(p1.Equals(p2));
            Console.Write("Objetos de p2 y p3 son iguales: ");
            Console.WriteLine(p2.Equals(p3));
            Console.Write("Objetos de p1 y p3 son iguales: ");
            Console.WriteLine(p1.Equals(p3));
        }
    }
}
