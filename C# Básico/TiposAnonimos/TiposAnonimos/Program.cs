using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposAnonimos
{
    /// <summary>
    /// Tipos anónimos
    /// Son una forma conveniente de encapsuar un conjunto de propiedades
    /// de solo lectura en un objeto, sin tener que crear una clase
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Define el tipo anónimo con new y un inicializador
            var anonimo = new
            {
                Nombre = "LMD01",
                Precio = 1234.5,
                Serie = 2
            };

            // Mostrando los datos del objeto anónimo
            Console.WriteLine("Datos del objeto anónimo");
            Console.WriteLine(anonimo.Nombre);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Serie);
        }
    }
}
