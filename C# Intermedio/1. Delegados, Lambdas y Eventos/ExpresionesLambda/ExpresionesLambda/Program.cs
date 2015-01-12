using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    delegate void ImprimeMensaje(string mensaje);

    /// <summary>
    /// Expresiones Lambda
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeMensaje imprime = mensaje => Console.WriteLine(mensaje);

            imprime += mensaje => 
                File.WriteAllText(@"C:\Users\Enrique\Documents\mensaje_lambda.txt", mensaje);

            // El mensaje se manda a todos los métodos target del delegado
            RegistraMensaje(imprime, "Hola mundo multicast delegate con expresiones lambda");
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }
    }
}
