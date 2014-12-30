using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEstaticas
{
    /// <summary>
    /// Clase estática para convertir temperaturas C <-> F
    /// Una clase estática solo contiene miembros estáticos y
    /// no puede ser instanciada
    /// </summary>
    public static class ConversorTemperatura
    {
        public static double CelsiusToFahrenheit(this string temperaturaCelsius)
        {
            // Conviere el argumento a double para el cálculo 
            double celsius = double.Parse(temperaturaCelsius);

            // Convierte Celsius a Fahrenheit. 
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(this string temperaturaFahrenheit)
        {            
            double fahrenheit = double.Parse(temperaturaFahrenheit);

            // Convierte Fahrenheit a Celsius. 
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}
