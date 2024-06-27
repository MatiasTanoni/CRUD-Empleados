using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Tiempo
    {
        public delegate void NotificarCambioTiempo(object reloj, InfoTiempoEventArgs infoTiempo);

        public event NotificarCambioTiempo SegundoCambiado;

        // Método para simular el cambio de tiempo
        public void SimularCambioTiempo()
        {
            DateTime ahora = DateTime.Now;
            OnSegundoCambiado(new InfoTiempoEventArgs(ahora.Hour, ahora.Minute, ahora.Second, ahora));
        }

        // Método para invocar el evento SegundoCambiado
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

        public InfoTiempoEventArgs(int hora, int minuto, int segundos, DateTime tiempoActual)
        {
            Hora = hora;
            Minuto = minuto;
            Segundos = segundos;
            TiempoActual = tiempoActual;
        }
    }
}
