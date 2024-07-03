using Entidades;
using Entidades.Interfaces;

public class Tester : Empleado, IEmpleado<Tester>
{
    private new TipoDeEmpleados tipo;
    private string herramientaDePrueba = string.Empty;
    private int proyectosTesteados;

    /// <summary>
    /// Obtiene o establece el tipo por el tester.
    /// </summary>
    public new TipoDeEmpleados Tipo
    {
        get { return tipo; }
        set { tipo = value; }
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

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Tester"/>.
    /// </summary>
    public Tester()
    {

    }

    /// <summary>
    /// Inicializa una nueva instancia de la clase Tester con el nombre, la edad y la experiencia especificados.
    /// </summary>
    /// <param name="nombre">El nombre del tester.</param>
    /// <param name="edad">La edad del tester.</param>
    /// <param name="experiencia">La experiencia del tester.</param>
    public Tester(string nombre, int edad, int experiencia, int salario, TipoDeEmpleados tipo, int id) : base(nombre, edad, experiencia, salario, tipo, id)
    {

    }

    /// <summary>
    /// Constructor de la clase Tester que inicializa el salario, nombre, edad y experiencia del Tester.
    /// </summary>
    /// <param name="salario">El salario del Tester.</param>
    /// <param name="nombre">El nombre del Tester.</param>
    /// <param name="edad">La edad del Tester.</param>
    /// <param name="experiencia">La experiencia del Tester.</param>
    public Tester(int salario, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(nombre, edad, experiencia, salario, tipo, id)
    {

    }

    /// <summary>
    /// Constructor de la clase Tester que inicializa el salario, herramienta de prueba, nombre, edad y experiencia del Tester.
    /// </summary>
    /// <param name="salario">El salario del Tester.</param>
    /// <param name="herramientaDePrueba">La herramienta de prueba utilizada por el Tester.</param>
    /// <param name="nombre">El nombre del Tester.</param>
    /// <param name="edad">La edad del Tester.</param>
    /// <param name="experiencia">La experiencia del Tester.</param>
    public Tester(int salario, string herramientaDePrueba, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(salario, nombre, edad, experiencia, tipo, id)
    {
        this.herramientaDePrueba = herramientaDePrueba;
    }

    /// <summary>
    /// Constructor de la clase Tester que inicializa el salario, herramienta de prueba, proyectos testeados, nombre, edad y experiencia del Tester.
    /// </summary>
    /// <param name="salario">El salario del Tester.</param>
    /// <param name="herramientaDePrueba">La herramienta de prueba utilizada por el Tester.</param>
    /// <param name="proyectosTesteados">El número de proyectos testeados por el Tester.</param>
    /// <param name="nombre">El nombre del Tester.</param>
    /// <param name="edad">La edad del Tester.</param>
    /// <param name="experiencia">La experiencia del Tester.</param>
    public Tester(int salario, string herramientaDePrueba, int proyectosTesteados, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(salario, herramientaDePrueba, nombre, edad, experiencia, tipo, id)
    {
        this.proyectosTesteados = proyectosTesteados;
    }

    /// <summary>
    /// Compara dos objetos Tester para determinar si son iguales basándose en el salario, herramienta de prueba y proyectos testeados.
    /// </summary>
    /// <param name="tester">Primer objeto Tester a comparar.</param>
    /// <param name="tester1">Segundo objeto Tester a comparar.</param>
    /// <returns>True si ambos objetos Tester son iguales; False en caso contrario.</returns>
    public static bool operator ==(Tester tester, Tester tester1)
    {
        return tester.Salario == tester1.Salario && tester.HerramientaDePrueba == tester1.HerramientaDePrueba && tester.ProyectosTesteados == tester1.ProyectosTesteados;
    }

    /// <summary>
    /// Compara dos objetos Tester para determinar si son diferentes basándose en el salario, herramienta de prueba y proyectos testeados.
    /// </summary>
    /// <param name="tester">Primer objeto Tester a comparar.</param>
    /// <param name="tester1">Segundo objeto Tester a comparar.</param>
    /// <returns>True si los objetos Tester son diferentes; False si son iguales.</returns>
    public static bool operator !=(Tester tester, Tester tester1)
    {
        return tester.Salario != tester1.Salario && tester.HerramientaDePrueba != tester1.HerramientaDePrueba && tester.ProyectosTesteados != tester1.ProyectosTesteados;
    }

    /// <summary>
    /// Devuelve una cadena que representa la información del tester.
    /// </summary>
    /// <returns>Una cadena que contiene el nombre, la edad, la experiencia, el salario, la herramienta de prueba y la cantidad de proyectos testeados del tester.</returns>
    public override string MostrarInformacion()
    {
        return $"{this.tipo} - {base.ToString()} - {base.MostrarExperiencia()} - Salario: {this.salario} - Herramienta De Prueba: {this.herramientaDePrueba} - Testeo: {this.proyectosTesteados} proyectos - {ToString()}";
    }

    /// <summary>
    /// Devuelve una representación de cadena del objeto Tester.
    /// </summary>
    /// <returns>Una cadena que representa el objeto Tester.</returns>
    public override string ToString()
    {
        return "Informacion de un Tester";
    }

    /// <summary>
    /// Comprueba si el objeto actual es igual a otro objeto Tester.
    /// </summary>
    /// <param name="otroTester">El objeto que se va a comparar con el objeto actual.</param>
    /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, False.</returns>
    public override bool Equals(Object? otroTester)
    {
        return otroTester is Tester && this == (Tester)otroTester;
    }
    public override int GetHashCode()
    {
        return 0;
    }
}