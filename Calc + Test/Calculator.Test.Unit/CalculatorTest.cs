using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddNumbers_Addition_ReturnConfAddition()
        {
            // Arrange
            var uut = new Calc.Calculator();

            // Act
            double sum;
            sum = uut.Add(5, 5);

            // Assert
            Assert.That(sum, Is.EqualTo(10));
        }

        [Test]
        public void SubtractNumbers_Subtract_ReturnConfAddition()
        {
            // Arrange
            var uut = new Calc.Calculator();

            // Act
            double sum;
            sum = uut.Subtract(5, 5);

            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }
    }
}
