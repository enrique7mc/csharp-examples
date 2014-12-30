using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuras
{
    /// <summary>
    /// Representa un vector de 3 dimensiones
    /// </summary>
    public struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Un tipo struct no puede definir un constructor vacío

        public Vector(double x, double y, double z)
            : this() // siempre se debe llamar al constructor vacío
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Calcula el módulo de un vector definido como la raíz
        /// cuadrada de la suma de los cuadrados de sus componentes
        /// </summary>
        /// <returns>el módulo del vector</returns>
        public double CalcularModulo()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        /// <summary>
        /// Suma el vector con otro
        /// </summary>
        /// <param name="otro">vector con el que se hará la suma</param>
        /// <returns>el vector resultante de la suma</returns>
        public Vector Suma(Vector otro)
        {
            return new Vector(X + otro.X, Y + otro.Y, Z + otro.Z);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
    }
}
