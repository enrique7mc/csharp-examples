using System;

namespace ExcepcionesPropias
{
    /// <summary>
    /// Crear excepciones propias
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(
                   "Ingresa un valor para calcular su raíz cuadrada: ");
                double dato = Convert.ToDouble(Console.ReadLine());
                double resultado = RaizCuadrada(dato);

                Console.WriteLine("La raíz cuadrada de {0} es {1:F6}\n",
                   dato, resultado);
            } 
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
                Console.WriteLine("Ingresa un número.\n");
            } 
            catch (NegativeNumberException nne)
            {
                Console.WriteLine("\n" + nne.Message);
                Console.WriteLine("Ingresa un número no negativo.\n");
            }        
        }

        // calcula la raíz cuadrada de su argumento; lanza 
        // NegativeNumberException si éste es negativo
        public static double RaizCuadrada(double value)
        {
            // si el valor es negativo, lanza NegativeNumberException
            if (value < 0)
            {
                throw new NegativeNumberException(
                   "Raíz cuadradada de un número negativo no permitida");
            }
            else
            {
                return Math.Sqrt(value); // calcula raíz cuadrada
            }
        } 
    }
}
