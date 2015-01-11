using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    // Delcara un delegado que recibe un double y devuelve un double
    delegate double Operacion(double numero);

    /// <summary>
    /// Delegados
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxis para crear un objeto de tipo delegado
            //Operacion op = new Operacion(Cuadrado);

            // Sintaxis corta para crear un objeto de tipo delegado
            Operacion op = Cuadrado;

            // Ejecuta el método target del delegado
            double num = 5;
            double resultado = op(num);
            Console.WriteLine("{0} * {0} = {1}", num, resultado);

            // cambia el target del delegado
            op = Cubo;
            num = 10;
            resultado = op(num);
            Console.WriteLine("{0} * {0} = {1}", num, resultado);
        }

        static double Cuadrado(double numero)
        {
            return numero * numero;
        }

        static double Cubo(double numero)
        {
            return Math.Pow(numero, 3);
        }
    }
}
