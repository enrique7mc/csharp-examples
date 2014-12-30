using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParametrosOpcionales
{
    /// <summary>
    /// Parámetros opcionales
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Usar parámetro opcional
            double precio = 1234.5;
            double total = CalcularImpuesto(precio);
            Console.WriteLine("Precio: {0}, con IVA: {1}", precio, total);

            // Definir los dos parámetros
            precio = 435;
            total = CalcularImpuesto(precio, 0.2);
            Console.WriteLine("Precio: {0}, Precio + 20%: {1}", precio, total);
        }

        static double CalcularImpuesto(double cantidad, double porcentaje = 0.16)
        {
            // calcula y regresa la cantidad más el porcentaje de impuesto
            return cantidad * (1 + porcentaje);
        }

        // Ejemplo con dos parámetros opcionales
        public void OtroEjemplo(int requerido, string optionalstr = "default string",
            int optionalint = 10)
        {
            // hacer algo interesante aquí
        }
    }
}
