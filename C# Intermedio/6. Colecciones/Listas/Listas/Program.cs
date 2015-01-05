using System;
using System.Collections.Generic;

namespace Listas
{
    /// <summary>
    /// Uso de listas con la clase List
    /// </summary>
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Añade elementos de colors a la Lista (uno por uno)
            foreach(var color in colors)
            {
                list.Add(color);
            }

            // Añade elementos del arreglo desde el constructor
            List<string> removeList = new List<string>(removeColors);

            Console.WriteLine("List: ");
            MostrarLista(list); 

            // remueve colores
            RemueveColores(list, removeList);

            Console.WriteLine("\nList después de llamar a RemueveColores: ");
            MostrarLista(list);
        }

        private static void MostrarLista(List<string> list)
        {
            // muestra el contenido con foreach
            foreach(var element in list)
            {
                Console.Write("{0} ", element);
            }

            // muestra tamaño y capacidad
            Console.WriteLine("\nTamaño = {0}; Capacidad = {1}",
               list.Count, list.Capacity);

            int index = list.IndexOf("BLUE");

            if (index != -1)
                Console.WriteLine("La lista contiene BLUE en índice {0}.",
                   index);
            else
                Console.WriteLine("La lista no contiene BLUE.");
        }
        
        private static void RemueveColores(List<string> firstList,
           List<string> secondList)
        {
            for(int count = 0; count < secondList.Count; ++count)
            {
                firstList.Remove(secondList[count]);
            }
        }
    }
}
