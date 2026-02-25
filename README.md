Este refactor aplica los principios SOLID:

SRP (Single Responsibility Principle):
Se separaron las responsabilidades en clases independientes:
- NotificadorPushApp: envía notificaciones a la app
- NotificadorLogLocal: guarda en archivo

OCP (Open/Closed Principle):
Se creó la interfaz INotificador, permitiendo agregar nuevos notificadores (SMS, WhatsApp, Email) sin modificar el ProcesadorAlertas.

Esto hace el sistema extensible y mantenible.
