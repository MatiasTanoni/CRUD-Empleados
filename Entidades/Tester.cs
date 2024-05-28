using Entidades;

/// <summary>
/// Representa un empleado de tipo Tester en la empresa.
/// </summary>
public class Tester : Empleado
{
    // Atributos
    private int salario;
    private string herramientaDePrueba;
    private int proyectosTesteados;

    // Propiedades
    /// <summary>
    /// Obtiene o establece el salario del tester.
    /// </summary>
    public int Salario
    {
        set { salario = value; }
        get { return salario; }
    }

    /// <summary>
    /// Obtiene o establece la herramienta de prueba utilizada por el tester.
    /// </summary>
    public string HerramientaDePrueba
    {
        set { herramientaDePrueba = value; }
        get { return herramientaDePrueba; }
    }

    /// <summary>
    /// Obtiene o establece la cantidad de proyectos testeados por el tester.
    /// </summary>
    public int ProyectosTesteados
    {
        set { proyectosTesteados = value; }
        get { return proyectosTesteados; }
    }

    // Constructor

    /// <summary>
    /// Inicializa una nueva instancia de la clase Tester con el nombre, la edad y la experiencia especificados.
    /// </summary>
    /// <param name="nombre">El nombre del tester.</param>
    /// <param name="edad">La edad del tester.</param>
    /// <param name="experiencia">La experiencia del tester.</param>
    public Tester(string nombre, int edad, int experiencia) : base(nombre, edad, experiencia)
    {

    }

    /// <summary>
    /// Devuelve una cadena que representa la información del tester.
    /// </summary>
    /// <returns>Una cadena que contiene el nombre, la edad, la experiencia, el salario, la herramienta de prueba y la cantidad de proyectos testeados del tester.</returns>
    public override string MostrarInformacion()
    {
        return $"Nombre: {this.nombre} - Edad: {this.edad} - Experiencia: {this.experiencia} - Salario: {this.salario} - Herramienta De Prueba: {this.herramientaDePrueba} - Testeo: {this.proyectosTesteados} proyectos";
    }
    //public override string ToString()
    //{
    //    return this.MostrarInformacion();
    //}
}


