using System.Collections.Generic;

namespace NanoGuardian.Clean
{
    public class ProcesadorAlertas
    {
        private readonly IEnumerable<INotificador> _notificadores;

        public ProcesadorAlertas(IEnumerable<INotificador> notificadores)
        {
            _notificadores = notificadores;
        }

        public void Ejecutar(Alerta alerta)
        {
            foreach (var notificador in _notificadores)
            {
                notificador.Enviar(alerta);
            }
        }
    }
}