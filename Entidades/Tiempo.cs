using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Tiempo
    {
        // Delegado para notificar cambios de tiempo
        public delegate void NotificarCambioTiempo(object reloj, InfoTiempoEventArgs infoTiempo);

        // Evento que se dispara cuando cambia el segundo
        public event NotificarCambioTiempo SegundoCambiado;

        /// <summary>
        /// Método para simular el cambio de tiempo y notificar a los suscriptores.
        /// </summary>
        public void SimularCambioTiempo()
        {
            DateTime ahora = DateTime.Now;
            OnSegundoCambiado(new InfoTiempoEventArgs(ahora.Hour, ahora.Minute, ahora.Second, ahora));
        }

        /// <summary>
        /// Método para invocar el evento SegundoCambiado y notificar a los suscriptores.
        /// </summary>
        /// <param name="e">Argumentos del evento que contienen la información del tiempo actual.</param>
        protected virtual void OnSegundoCambiado(InfoTiempoEventArgs e)
        {
            SegundoCambiado?.Invoke(this, e);
        }
    }

    public class InfoTiempoEventArgs : EventArgs
    {
        public int Hora { get; }
        public int Minuto { get; }
        public int Segundos { get; }
        public DateTime TiempoActual { get; }

        /// <summary>
        /// Constructor que inicializa los argumentos del evento.
        /// </summary>
        /// <param name="hora">Hora actual.</param>
        /// <param name="minuto">Minuto actual.</param>
        /// <param name="segundos">Segundo actual.</param>
        /// <param name="tiempoActual">Fecha y hora actual.</param>
        public InfoTiempoEventArgs(int hora, int minuto, int segundos, DateTime tiempoActual)
        {
            Hora = hora;
            Minuto = minuto;
            Segundos = segundos;
            TiempoActual = tiempoActual;
        }
    }
}
