using System;
using OtroNamespace;

namespace ControlAcceso
{
    /// <summary>
    /// Control de acceso con palabras reservadas
    /// public, internal, private y protected
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Con la sentencia using podemos omitir los nombres de
            // otros namespaces
            MiClase obj = new MiClase();
            obj.MetodoPublico();
            obj.MetodoInternal();
            // No podemos acceder a MetodoProtected
            // o MetodoPrivado debido a su nivel de acceso
        }
    }
}
