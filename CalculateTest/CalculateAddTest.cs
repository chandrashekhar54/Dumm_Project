using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculateAddTest
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            double num1 = 5.0;
            double num2 = 3.0;

            // Act
            double result = Calculate.Add(num1, num2);

            // Assert
            Assert.AreEqual(10.0, result);
        }
    }
}
