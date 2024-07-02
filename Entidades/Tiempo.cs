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
        /// Constructor que inicializa los argumentos del tiempo actual.
        /// </summary>
        /// <param name="hora">Hora del tiempo actual.</param>
        /// <param name="minuto">Minuto del tiempo actual.</param>
        /// <param name="segundos">Segundos del tiempo actual.</param>
        /// <param name="tiempoActual">Momento exacto del tiempo actual.</param>
        public InfoTiempoEventArgs(int hora, int minuto, int segundos, DateTime tiempoActual)
        {
            Hora = hora;
            Minuto = minuto;
            Segundos = segundos;
            TiempoActual = tiempoActual;
        }
    }
}