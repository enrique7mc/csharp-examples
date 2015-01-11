using System;
using System.IO;

namespace MetodosAnonimos
{
    delegate void ImprimeMensaje(string mensaje);

    /// <summary>
    /// Métodos anónimos
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
