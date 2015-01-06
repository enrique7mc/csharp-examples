using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ContadorPalabras
{
    /// <summary>
    /// Contador de palabras utilizando un Dictionary<string, int>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> palabras = OrganizarPalabras();

            MostrarPalabras(palabras);
        }

        public static IDictionary<string, int> OrganizarPalabras()
        {
            var palabras = new Dictionary<string, int>();
            //var palabras = new SortedDictionary<string, int>(); 

            Console.WriteLine("Ingresa una cadena: "); 
            string input = Console.ReadLine(); 

            // partir la cadena en palabras
            string[] words = Regex.Split(input, @"\s+");
            
            foreach (var word in words)
            {
                string wordKey = word.ToLower(); // convertir la palabra a minúscula

                // Revisa si el diccionario contiene la palabra
                if (palabras.ContainsKey(wordKey))
                {
                    // aumenta el contador en 1
                    palabras[wordKey] = ((int)palabras[wordKey]) + 1;
                }
                else
                {
                    // si la palabra es nueva, la añade con contador 1
                    palabras.Add(wordKey, 1);
                }
            } 

            return palabras;
        }

        private static void MostrarPalabras(IDictionary<string, int> palabras)
        {
            Console.WriteLine("\nContenido del diccionario:\n{0,-12}{1,-12}",
               "Key:", "Value:");

            // genera una tabla con las llaves y valores del diccionario           
            foreach (var key in palabras.Keys)
            {
                Console.WriteLine("{0,-12}{1,-12}", key, palabras[key]);
            }

            Console.WriteLine("\nsize: {0}", palabras.Count);
        }

    }
}
