using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TiposPredefinidos
{
    /// <summary>
    /// Tipos predefinidos en C#
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos enteros
            // System.Int32
            int entero = 1100; // 32 bits
            // System.Int16
            short s = 140; // 16 bits
            // System.Byte            
            byte b = 10; // 8 bits
            // System.Int64
            long largo = 12341234123; // 64 bits

            Console.WriteLine("int: {0}, short: {1}", entero, s);

            // Tipos flotantes
            // System.Single
            float f = 123.5f;
            // System.Double            
            double d = 3.14592;
            // System.Decimal utilizado para operaciones financieras            
            decimal dec = 139.99m;

            Console.WriteLine("float: {0}, dec: {1}", f, dec);

            // Otros
            // System.Char representa un carácter            
            char c = 'E';
            // System.Boolean representa un valor verdadero o falso
            bool booleano = true;

            Console.Write("char: {0}", c);
            Console.WriteLine("bool: {0}", booleano);
        }
    }
}
