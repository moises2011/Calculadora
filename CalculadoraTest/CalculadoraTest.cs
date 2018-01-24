using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora
{
    [TestClass]
    public class CalculadoraTest
    {
        Calculadora calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculadora();
        }

        [TestMethod]
        public void SumarTest()
        {
            //Arrange
            int totalEsperado = 4;
            int a = 2;
            int b = 2;
            //Act
            int total = calc.Sumar(a, b);
            //Assert
            Assert.AreEqual(total, totalEsperado);
        }
    }
}
