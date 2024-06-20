namespace TestUnitarios
{
    [TestClass]
    public class FormConfiguraciones
    {
        [TestMethod]
        public void ValidarEdad_EdadValida_ReturnsTrue()
        {
            // Arrange
            var empleado = new Empleado();
            var textBox = new TextBox { Text = "30" };
            var formulario = new FormConfiguraciones(); // Reemplaza con el formulario o clase que contiene el método

            // Act
            var result = formulario.ValidarEdad(empleado, textBox);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(30, empleado.Edad);
        }

        [TestMethod]
        public void ValidarEdad_EdadJubilacion_ReturnsFalse()
        {
            // Arrange
            var empleado = new Empleado();
            var textBox = new TextBox { Text = "65" };
            var formulario = new FormConfiguraciones(); // Reemplaza con el formulario o clase que contiene el método

            // Act
            var result = formulario.ValidarEdad(empleado, textBox);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarEdad_EdadMenorDeEdad_ReturnsFalse()
        {
            // Arrange
            var empleado = new Empleado();
            var textBox = new TextBox { Text = "17" };
            var formulario = new FormConfiguraciones(); // Reemplaza con el formulario o clase que contiene el método

            // Act
            var result = formulario.ValidarEdad(empleado, textBox);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarEdad_EdadNoNumerica_ReturnsFalse()
        {
            // Arrange
            var empleado = new Empleado();
            var textBox = new TextBox { Text = "abc" };
            var formulario = new FormConfiguraciones(); // Reemplaza con el formulario o clase que contiene el método

            // Act
            var result = formulario.ValidarEdad(empleado, textBox);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarEdad_EdadVacia_ReturnsFalse()
        {
            // Arrange
            var empleado = new Empleado();
            var textBox = new TextBox { Text = "" };
            var formulario = new FormConfiguraciones(); // Reemplaza con el formulario o clase que contiene el método

            // Act
            var result = formulario.ValidarEdad(empleado, textBox);

            // Assert
            Assert.IsFalse(result);
        }
    }
}