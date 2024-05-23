namespace Entidades
{
    public abstract class Empleado
    {
        // Atributos
        protected string nombre;
        protected int edad;
        protected int experiencia;
        
        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        // Constructor
        public Empleado()
        {
            this.nombre = "";
            this.edad = 0;
            this.experiencia = 0;
        }
        public Empleado(string nombre):this()
        {
            this.nombre = nombre;         
        }
        public Empleado(string nombre, int edad) : this(nombre)
        {
            this.edad = edad;
        }
        public Empleado(string nombre, int edad, int experiencia) : this(nombre, edad)
        {
            this.experiencia = experiencia;
        }

        public abstract string MostrarInformacion();


    }

}
