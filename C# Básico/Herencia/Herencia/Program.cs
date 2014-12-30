using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    /// <summary>
    /// Herencia
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 38);
            p.Saludar();

            Empleado e = new Empleado("María", 29, "RH", 10000);
            e.Saludar();
            e.Trabajar();
        }
    }
}
