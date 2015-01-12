using System;

namespace Eventos
{
    class Alarma
    {
        public event EventHandler<EventArgs> Sonar;

        public void ActivarAlarma()
        {
            while (true)
            {
                // La alarma suena cada 5 segundos
                System.Threading.Thread.Sleep(5000);
                if (Sonar != null)
                {
                    Sonar(this, EventArgs.Empty);
                }
            }
        }
    }
}