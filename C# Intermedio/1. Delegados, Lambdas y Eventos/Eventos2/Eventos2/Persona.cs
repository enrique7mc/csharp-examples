using System;

namespace Eventos2
{
    class Persona
    {
        public void Subscribe(Alarma m)
        {
            m.Sonar += EscucharAlarma;
        }
        private void EscucharAlarma(object sender, AlarmaActivadaEventArgs e)
        {
            Console.WriteLine("Escuchó alarma a las: {0:HH:mm:ss}", e.Hora);
        }
    }
}
