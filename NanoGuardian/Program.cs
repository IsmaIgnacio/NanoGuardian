using System;
using System.Collections.Generic;
using NanoGuardian.Clean;

namespace NanoGuardian
{
    class Program
    {
        static void Main(string[] args)
        {
            var alerta = new Alerta
            {
                Paciente = "Juan Pérez",
                FuerzaImpacto = 4.2,
                Fecha = DateTime.Now
            };

            var notificadores = new List<INotificador>
            {
                new NotificadorPushApp(),
                new NotificadorLogLocal()
            };

            var procesador = new ProcesadorAlertas(notificadores);

            procesador.Ejecutar(alerta);

            Console.ReadLine();
        }
    }
}