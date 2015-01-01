using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LecturaEscritura
{
    /// <summary>
    /// Lectura y escritura de archivos de texto
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("prueba.txt"))
            {
                Console.Write("Escritura a un archivo\nEscribe un mensaje: ");
                string str =  Console.ReadLine();
                while (String.Compare(str, "salir", true) != 0)
                {
                    writer.WriteLine(str);
                    Console.Write("Escribe un mensaje: ");
                    str = Console.ReadLine();
                }                    
            }

            Console.WriteLine("Lectura desde un archivo\nContenido de prueba.txt");            
            using (var reader = new StreamReader("prueba.txt"))
            {
                string str = null;
                while ((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
