using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    /// <summary>
    /// Expresiones Lambda
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }
    }
}
