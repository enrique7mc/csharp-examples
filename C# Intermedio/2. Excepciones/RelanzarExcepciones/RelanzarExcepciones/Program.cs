using System;

namespace RelanzarExcepciones
{
    /// <summary>
    /// Relanzar excepciones
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Case 4: Una excepción es lanzada y atrapada en el método
            // llamado, después se relanza
            Console.WriteLine("\nLlama RelanzaExcepcion");

            // llama RelanzaExcepcion
            try
            {
                RelanzaExcepcion();
            }
            catch
            {
                Console.WriteLine("Atrapada excepción desde RelanzaExcepcion en Main");
            }
        }

        static void RelanzaExcepcion()
        {            
            try
            {
                Console.WriteLine("En RelanzaExcepcion");
                throw new Exception("Excepcion en RelanzaExcepcion");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje: " + ex.Message);

                // relanzar la excepción para procesamiento posterior
                throw;                
            }
            finally
            {
                Console.WriteLine("finally ejecutado en RelanzaExcepcion");
            }            
        }
    }
}
