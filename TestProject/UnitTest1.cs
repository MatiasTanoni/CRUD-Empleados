using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestProject
{
    /// <summary>
    /// Clase de pruebas unitarias para la clase Tester.
    /// </summary>
    [TestClass]
    public class TesterTests
    {
        /// <summary>
        /// Prueba el constructor sin parámetros de Tester, asegurando que inicializa correctamente los valores por defecto.
        /// </summary>
        [TestMethod]
        public void Constructor_SinParametros_DeberiaInicializarValoresPorDefecto()
        {
            // Arrange & Act
            var tester = new Tester();

            // Assert
            Assert.AreEqual(string.Empty, tester.HerramientaDePrueba);
            Assert.AreEqual(0, tester.ProyectosTesteados);
        }

        /// <summary>
        /// Prueba el constructor de Tester con todos los parámetros, asegurando que inicializa todas las propiedades correctamente.
        /// </summary>
        [TestMethod]
        public void Constructor_ConTodosLosParametros_DeberiaInicializarTodasLasPropiedades()
        {
            // Arrange
            int salario = 50000;
            string herramientaDePrueba = "Selenium";
            int proyectosTesteados = 10;
            string nombre = "Juan";
            int edad = 30;
            int experiencia = 5;
            TipoDeEmpleados tipo = TipoDeEmpleados.Tester;
            int id = 1;

            // Act
            var tester = new Tester(salario, herramientaDePrueba, proyectosTesteados, nombre, edad, experiencia, tipo, id);

            // Assert
            Assert.AreEqual(salario, tester.Salario);
            Assert.AreEqual(herramientaDePrueba, tester.HerramientaDePrueba);
            Assert.AreEqual(proyectosTesteados, tester.ProyectosTesteados);
            Assert.AreEqual(nombre, tester.Nombre);
            Assert.AreEqual(edad, tester.Edad);
            Assert.AreEqual(experiencia, tester.Experiencia);
            Assert.AreEqual(tipo, tester.Tipo);
            Assert.AreEqual(id, tester.Id);
        }

        /// <summary>
        /// Prueba el operador de igualdad (==) para Tester, asegurando que retorna true para dos Testers iguales.
        /// </summary>
        [TestMethod]
        public void OperadorIgualdad_DeberiaRetornarTrueParaTestersIguales()
        {
            // Arrange
            var tester1 = new Tester(50000, "Selenium", 10, "Juan", 30, 5, TipoDeEmpleados.Tester, 1);
            var tester2 = new Tester(50000, "Selenium", 10, "Juan", 30, 5, TipoDeEmpleados.Tester, 1);

            // Act & Assert
            Assert.IsTrue(tester1 == tester2);
        }

        /// <summary>
        /// Prueba el operador de desigualdad (!=) para Tester, asegurando que retorna true para dos Testers diferentes.
        /// </summary>
        [TestMethod]
        public void OperadorDesigualdad_DeberiaRetornarTrueParaTestersDiferentes()
        {
            // Arrange
            var tester1 = new Tester(50000, "Selenium", 10, "Juan", 30, 5, TipoDeEmpleados.Tester, 1);
            var tester2 = new Tester(60000, "JUnit", 12, "Pedro", 35, 6, TipoDeEmpleados.Tester, 2);

            // Act & Assert
            Assert.IsTrue(tester1 != tester2);
        }

        /// <summary>
        /// Prueba el método MostrarInformacion de Tester, asegurando que retorna una cadena con información relevante del Tester.
        /// </summary>
        [TestMethod]
        public void MostrarInformacion_DeberiaRetornarCadenaConInformacionDelTester()
        {
            // Arrange
            var tester = new Tester(50000, "Selenium", 10, "Juan", 30, 5, TipoDeEmpleados.Tester, 1);

            // Act
            var info = tester.MostrarInformacion();

            // Assert
            Assert.IsTrue(info.Contains("Selenium"));
            Assert.IsTrue(info.Contains("50000"));
            Assert.IsTrue(info.Contains("10"));
        }
    }

}
