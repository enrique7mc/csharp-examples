namespace Eventos2
{
    /// <summary>
    /// Paso de argumentos a eventos con EventArgs
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
