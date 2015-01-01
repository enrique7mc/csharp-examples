using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;    
        }

        public virtual void Saludar() 
        {
            Console.WriteLine("Hola, mi nombre es {0}", Nombre);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }
    }
}
