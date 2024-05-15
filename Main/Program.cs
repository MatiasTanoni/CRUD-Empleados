using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        Empresa empresa = new Empresa();
        Desarrollador desarrollador = new Desarrollador(1000,"JS",10,"matias",20,30);
        Tester tester = new Tester(1000,"postman",15,"Juan",30,50);
        Gerente gerente = new Gerente(3000,3,5,"pepe",20,10);
        Console.WriteLine(empresa + gerente);
        Console.WriteLine(empresa + tester);
        Console.WriteLine(empresa + desarrollador);

        foreach (Empleado empleadoo in empresa.ListaDeEmpleados)
        {
            Console.WriteLine(empleadoo.MostrarInformacion());
        }
    }
}