using System;
using System.IO;

namespace NanoGuardian.Legacy
{
    public class AlertaManager
    {
        public void ProcesarCaida(string paciente, double fuerzaImpactoG)
        {
            string mensaje = $"[ALERTA CRÍTICA] El paciente {paciente} ha sufrido una caída de {fuerzaImpactoG}G a las {DateTime.Now}.";

            Console.WriteLine("Conectando al servidor WiFi...");
            Console.WriteLine($"Enviando Push Notification a la App: {mensaje}");

            Console.WriteLine("Abriendo archivo local...");
            File.AppendAllText("registro_caidas.txt", mensaje + Environment.NewLine);
        }
    }
}