using System;
using System.IO;

namespace EjemploMulticastDelegate
{
    delegate void ImprimeMensaje(string mensaje);

    class Program
    {
        static void Main(string[] args)
        {
            // Genera un multicast delegate
            ImprimeMensaje imprime = ImprimeEnConsola;
            imprime += ImprimeEnArchivo;

            // El mensaje se manda a todos los métodos target del delegado
            RegistraMensaje(imprime, "Hola mundo multicast delegate");
        }

        static void ImprimeEnConsola(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void ImprimeEnArchivo(string mensaje)
        {
            File.WriteAllText(@"C:\Users\Enrique\Documents\mensaje.txt", mensaje);
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }
    }
}
