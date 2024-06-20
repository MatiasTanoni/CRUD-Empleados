//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Windows.Forms; // Asegúrate de tener la referencia a System.Windows.Forms
//using TuProyecto; // Reemplaza con el nombre del espacio de nombres de tu proyecto
//using Entidades;
//using Formularios;

//namespace TestProject1
//{
//    [TestClass]
//    public class FormConfiguracionesTests // Renombramos la clase para evitar confusión
//    {
//        [TestMethod]
//        public void ValidarEdad_EdadValida_ReturnsTrue()
//        {
//            // Arrange
//            var empleado = new Empleado();
//            var textBox = new TextBox { Text = "30" };
//            var formulario = new FormConfiguraciones(); // Esta es la clase que contiene el método ValidarEdad

//            // Act
//            var result = formulario.ValidarEdad(empleado, textBox);

//            // Assert
//            Assert.IsTrue(result);
//            Assert.AreEqual(30, empleado.Edad);
//        }

//        [TestMethod]
//        public void ValidarEdad_EdadJubilacion_ReturnsFalse()
//        {
//            // Arrange
//            var empleado = new Empleado();
//            var textBox = new TextBox { Text = "65" };
//            var formulario = new FormConfiguraciones();

//            // Act
//            var result = formulario.ValidarEdad(empleado, textBox);

//            // Assert
//            Assert.IsFalse(result);
//        }

//        [TestMethod]
//        public void ValidarEdad_EdadMenorDeEdad_ReturnsFalse()
//        {
//            // Arrange
//            var empleado = new Empleado();
//            var textBox = new TextBox { Text = "17" };
//            var formulario = new FormConfiguraciones();

//            // Act
//            var result = formulario.ValidarEdad(empleado, textBox);

//            // Assert
//            Assert.IsFalse(result);
//        }

//        [TestMethod]
//        public void ValidarEdad_EdadNoNumerica_ReturnsFalse()
//        {
//            // Arrange
//            var empleado = new Empleado();
//            var textBox = new TextBox { Text = "abc" };
//            var formulario = new FormConfiguraciones();

//            // Act
//            var result = formulario.ValidarEdad(empleado, textBox);

//            // Assert
//            Assert.IsFalse(result);
//        }

//        [TestMethod]
//        public void ValidarEdad_EdadVacia_ReturnsFalse()
//        {
//            // Arrange
//            var empleado = new Empleado();
//            var textBox = new TextBox { Text = "" };
//            var formulario = new FormConfiguraciones();

//            // Act
//            var result = formulario.ValidarEdad(empleado, textBox);

//            // Assert
//            Assert.IsFalse(result);
//        }
//    }
//}
