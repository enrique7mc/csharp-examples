using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Circulo : IFigura
    {
        public int Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirculo()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }
    }
}
