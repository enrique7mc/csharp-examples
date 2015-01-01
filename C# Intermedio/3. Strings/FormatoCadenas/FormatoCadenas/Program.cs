using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatoCadenas
{
    /// <summary>
    /// Dar formato a cadenas
    /// Console.WriteLine y string.Format
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;
            string ejemplo = string.Format("Hay {0} plátanos, {1} naranjas y {2} manzanas", 
                    platanos, naranjas, manzanas);

            Console.WriteLine(ejemplo);

            // Ajuste de decimales
            Console.WriteLine("Pi: {0:0.00}", Math.PI);

            // Ajustar dato con 10 caracteres de espacio
            Console.WriteLine(">{0,10}<", 5);
            // Ajustar dato con 10 caracteres de espacio a la izquierda
            Console.WriteLine(">{0,-10}<", 5);

            // Distintos formatos
            Console.WriteLine("Número: {0:N}", 126);
            Console.WriteLine("Científico: {0:E}", 126);
            Console.WriteLine("Moneda: {0:C}", 126);
            Console.WriteLine("Porcentaje: {0:P}", 126);
            Console.WriteLine("Hexadecimal: {0:X}", 126);
        }
    }
}
