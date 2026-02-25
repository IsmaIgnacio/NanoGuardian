using System;
using System.IO;

namespace NanoGuardian.Clean
{
    public class NotificadorLogLocal : INotificador
    {
        public void Enviar(Alerta alerta)
        {
            string mensaje = $"Paciente: {alerta.Paciente} - Impacto: {alerta.FuerzaImpacto}G - Fecha: {alerta.Fecha}";

            File.AppendAllText("registro_caidas.txt", mensaje + Environment.NewLine);

            Console.WriteLine("[LOG] Guardado en archivo.");
        }
    }
}