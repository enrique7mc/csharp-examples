using System;
using System.Threading;

namespace Eventos2
{
    class Alarma
    {
        public event EventHandler<AlarmaActivadaEventArgs> Sonar;

        public void ActivarAlarma()
        {
            while (true)
            {
                // La alarma suena cada 5 segundos
                Thread.Sleep(5000);
                if (Sonar != null)
                {
                    AlarmaActivadaEventArgs args = 
                        new AlarmaActivadaEventArgs {Hora = DateTime.Now};
                    Sonar(this, args);
                }
            }
        }
    }
}
