using System;
using System.Text;

namespace UsoStringBuilder
{
    /// <summary>
    /// La clase StringBuilder permite manipular cadenas
    /// con mejor rendimiento para la aplicación.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Cadena de prueba");

            // propiedades Length y Capacity 
            Console.WriteLine("buffer: {0}\nLength: {1}\nCapacity: {2}",
                builder, builder.Length, builder.Capacity);            

            builder.EnsureCapacity(75); // asegura una capacidad de 75
            Console.WriteLine("\nNew capacity = " +
               builder.Capacity);

            object[] datos = {"cadena", 1, 0.5, false, 'c', 8};
            foreach(var dato in datos)
            {
                builder.Append(dato + " ");
            }

            Console.WriteLine(builder.ToString());
            builder.Insert(0, "Inserta al principio");

            Console.WriteLine(builder.ToString());            
        }
    }
}
