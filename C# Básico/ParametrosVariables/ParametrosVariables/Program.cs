using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParametrosVariables
{
    class Program
    {
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /* Se puede especificar una lista separada por 
               comas del tipo especificado */            
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "prueba");

            /* params acepta cero o más argumentos */            
            UseParams2();

            /* Se puede pasar un arreglo, mientras coincida con el
               tipo del parametro definido, en este caso int */            
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);

            object[] myObjArray = { 2, 'b', "prueba", "hola" };
            UseParams2(myObjArray);

            /* La siguiente línea genera un error de compilación 
               porque un arreglo de object's no puede convertirse
               en un arreglo de enteros */            
            //UseParams(myObjArray);

            /* La siguiente llamada no causa error porque el arreglo
               de enteros se convierte en el primer y único elemento
               de params */            
            UseParams2(myIntArray);
        }        
    }
}
