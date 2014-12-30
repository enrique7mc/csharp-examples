using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    /// <summary>
    /// Polimorfismo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            IFigura f1 = new Circulo { Radio = 5 };            
            IFigura f2 = new Triangulo { Base = 10, Altura = 8 };
            IFigura f3 = new Rectangulo { Base = 4, Altura = 3 };
            IFigura f4 = new Circulo { Radio = 9 };

            IFigura[] figuras = new IFigura[] { f1, f2, f3, f4 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }

            // Dowcasting
            Circulo c = f1 as Circulo;
            Console.WriteLine("Datos del círculo");
            c.DatosCirculo();
        }
    }
}
