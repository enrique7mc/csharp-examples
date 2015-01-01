using System;

namespace MiNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MiNamespace");
        }
    }
}

namespace OtroNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de OtroNamespace");
        }
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando objetos de clases contenidas en otros namespaces
            MiNamespace.Clase1 obj1 = new MiNamespace.Clase1();
            OtroNamespace.Clase1 obj2 = new OtroNamespace.Clase1();

            obj1.Metodo();
            obj2.Metodo();
        }
    }
}
