using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposDeReferencia
{
    /// <summary>
    /// Tipos de referencia
    /// Los tipos de referencia también son conocidos como objetos    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto
            object ob = new object();

            // Cadena
            string cadena = "Esta es una cadena";

            // Referencia especial null
            // Solo los tipos de referencia pueden ser asignados a null
            string cadenaNula = null;
            object objetoNulo = null;

            // Referencia a un tipo dinamico
            dynamic din;
        }
    }
}
