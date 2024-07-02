namespace Entidades.Interfaces
{
    internal interface IEmpleado<T>
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        int Experiencia { get; set; }
        int Salario { get; set; }

        string MostrarInformacion();
    }
}