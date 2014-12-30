using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    /// <summary>
    /// Clases
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Creando un objeto de tipo Rectángulo
            Rectangulo rect = new Rectangulo();
            rect.Base = 10;
            rect.Altura = 5;

            int area = rect.CalcularArea();
            Console.WriteLine("rect: {0} x {1}, area: {2}", rect.Base, rect.Altura, area);

            // Sintaxis de inicialización
            Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };

            int area2 = rect2.CalcularArea();
            Console.WriteLine("rect2: {0} x {1}, area: {2}", rect2.Base, rect2.Altura, area2);
        }
    }
}
