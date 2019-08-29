using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cal;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Cal.Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Cal.Calculator();
        }

        [TestCase(10, 5, 15)]
        [TestCase(-10, -5, -15)]
        [TestCase(-10, 5, -5)]
        [TestCase(10, -5, 5)]
        public void Add_CorrectResult(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 5)]
        [TestCase(-10, -5, -5)]
        [TestCase(-10, 5, -15)]
        [TestCase(10, -5, 15)]
        public void Subtract_CorrectResult(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 50)]
        [TestCase(-10, -5, 50)]
        [TestCase(-10, 5, -50)]
        [TestCase(10, -5, -50)]
        public void Multiply_CorrectResult(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 2, 100)]
        [TestCase(-10, -2, 0.01)]
        [TestCase(-10, 2, 100)]
        [TestCase(4, -2, 0.0625)]
        public void Power_CorrectResult(double a, double b, double result)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(result));
        }
    }
}
