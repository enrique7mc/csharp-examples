using System;

namespace Eventos
{
    class Persona
    {
        public void Subscribe(Alarma m)
        {
            m.Sonar += EscucharAlarma;
        }
        private void EscucharAlarma(object sender, EventArgs e)
        {
            Console.WriteLine("Escuchó alarma");
        }
    }
}