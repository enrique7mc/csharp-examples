using System;

namespace ManejoFechas
{
    /// <summary>
    /// Manejo de fechas con DateTime
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime.Now almacena la fecha y hora actual
            Console.WriteLine("Fecha y hora actual");
            Console.WriteLine(DateTime.Now);

            // Construir una fecha (año, mes, día, hora, minuto, segundo)
            Console.WriteLine("Fecha personalizada");
            DateTime dt = new DateTime(2000, 2, 3, 10, 20, 30);
            Console.WriteLine(dt.Year);         // 2000
            Console.WriteLine(dt.Month);        // 2
            Console.WriteLine(dt.Day);          // 3
            Console.WriteLine(dt.DayOfWeek);    // Thursday            
            Console.WriteLine(dt.Hour);         // 10
            Console.WriteLine(dt.Minute);       // 20
            Console.WriteLine(dt.Second);       // 30

            // Añadir días 10 días
            Console.WriteLine(dt.AddDays(10));
            // Restar 2 años
            Console.WriteLine(dt.AddYears(-2));
            // Añadir 45 minutos
            Console.WriteLine(dt.AddMinutes(45));
        }
    }
}
