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
        [Test]
        public void Divide_By_Zero()
        {
            Assert.Throws<Exception>(() => _uut.Divide(2, 0));
        }

        [TestCase(10, 30)]
        [TestCase(-5, 15)]
        [TestCase(100, 120)]
        public void Add_CorrectResult(double a, double result)
        {
            Assert.That(_uut.Add(a), Is.EqualTo(result));
        }

        [TestCase(10, 10)]
        [TestCase(-5, 25)]
        [TestCase(50, -30)]
        public void Subtract_CorrectResult(double a, double result)
        {
            Assert.That(_uut.Subtract(a), Is.EqualTo(result));
        }

        [TestCase(10, 200)]
        [TestCase(-5, -100)]
        [TestCase(50, 1000)]
        public void Multiply_CorrectResult(double a, double result)
        {
            Assert.That(_uut.Multiply(a), Is.EqualTo(result));
        }

        [TestCase(10, 2)]
        [TestCase(-5, -4)]
        [TestCase(50, 0.4)]
        public void Divide_CorrectResult(double a, double result)
        {
            Assert.That(_uut.Divide(a), Is.EqualTo(result));
        }

        [TestCase(10, 10240000000000)]
        [TestCase(5, 3200000)]
        public void Power_CorrectResult(double a, double result)
        {
            Assert.That(_uut.Power(a), Is.EqualTo(result));
        }





    }
}
