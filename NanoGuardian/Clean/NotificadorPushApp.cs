using System;

namespace NanoGuardian.Clean
{
    public class NotificadorPushApp : INotificador
    {
        public void Enviar(Alerta alerta)
        {
            Console.WriteLine($"[APP] Notificación enviada: {alerta.Paciente} cayó con {alerta.FuerzaImpacto}G.");
        }
    }
}