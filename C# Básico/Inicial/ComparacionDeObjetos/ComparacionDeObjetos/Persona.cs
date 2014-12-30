using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparacionDeObjetos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
