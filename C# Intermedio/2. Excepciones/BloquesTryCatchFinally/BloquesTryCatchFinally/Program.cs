using System;

namespace BloquesTryCatchFinally
{
    class Program
    {
        static void Main()
        {
            // Caso 1: No ocurren excepciones al llamar al método
            Console.WriteLine("Llama NoLanzaExcepcion");
            NoLanzaExcepcion();

            // Caso 2: Una excepción ocurre pero es atrapada en el método llamado
            Console.WriteLine("\nLlama LanzaExcepcionConCatch");
            LanzaExcepcionConCatch();

            // Caso 3: Una excepción ocurre en el método llamado pero no es
            // atrapada, debemos usar try catch
            Console.WriteLine("\nLlama LanzaExcepcionSinCatch");

            // llama LanzaExcepcionSinCatch
            try
            {
                LanzaExcepcionSinCatch();
            }
            catch
            {
                Console.WriteLine("Excepción atrapada desde LanzaExcepcionSinCatch en Main");
            }            
        } 

        // no exceptions thrown
        static void NoLanzaExcepcion()
        {             
            try
            {
                Console.WriteLine("En NoLanzaExcepcion");
            }
            catch
            {
                Console.WriteLine("Este catch nunca se ejecuta");
            }
            finally
            {
                Console.WriteLine("finally ejecutado en NoLanzaExcepcion");
            }                                                  

            Console.WriteLine("Fin de NoLanzaExcepcion");
        } 

        // lanza una excepción y la atrapa
        static void LanzaExcepcionConCatch()
        {            
            try
            {
                Console.WriteLine("En LanzaExcepcionConCatch");
                throw new Exception("Exception en LanzaExcepcionConCatch");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje: " + ex.Message);
            }
            finally
            {
                Console.WriteLine(
                   "finally ejecutado en LanzaExcepcionConCatch");
            }

            Console.WriteLine("Fin de LanzaExcepcionConCatch");
        }
        
        // lanza una excepción pero no la atrapa
        static void LanzaExcepcionSinCatch()
        {            
            try
            {
                Console.WriteLine("En LanzaExcepcionSinCatch");
                throw new Exception("Excepcion en LanzaExcepcionSinCatch");
            } // end try
            finally
            {
                Console.WriteLine("finally ejecutado en LanzaExcepcionSinCatch");
            }                          

            // código inalcanzable; error lógico
            Console.WriteLine("Fin de LanzaExcepcionSinCatch");
        }         
    }
}
