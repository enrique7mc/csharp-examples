namespace Eventos
{
    /// <summary>
    /// Uso de eventos en C#
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Alarma alarma = new Alarma();
            Persona persona = new Persona();

            persona.Subscribe(alarma);
            alarma.ActivarAlarma();
        }
    }
}
