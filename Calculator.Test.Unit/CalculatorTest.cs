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

        #region Setup
        private Cal.Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Cal.Calculator();
        }
        #endregion

        #region Without Accumulator

        [TestCase(10, 5, 15)]
        [TestCase(-10, -5, -15)]
        [TestCase(-10, 5, -5)]
        [TestCase(10, -5, 5)]
        public void Add_CorrectResult(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 5)]
        [TestCase(-10, -5, -5)]
        [TestCase(-10, 5, -15)]
        [TestCase(10, -5, 15)]
        public void Subtract_CorrectResult(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 50)]
        [TestCase(-10, -5, 50)]
        [TestCase(-10, 5, -50)]
        [TestCase(10, -5, -50)]
        public void Multiply_CorrectResult(double a, double b, double result)
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


        [TestCase(20, 10, 2)]
        [TestCase(20, -5, -4)]
        [TestCase(20, 50, 0.4)]
        public void Divide_CorrectResult(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Divide_By_Zero()
        {
            Assert.Throws<Exception>(() => _uut.Divide(2, 0));
        }

        #endregion

        #region With Accumulator

        [TestCase(20, 10, 30)]
        [TestCase(20, -5, 15)]
        [TestCase(-20, -100, -120)]
        public void Add_CorrectResult_WithAccumulator(double accumulator, double b, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Add(b), Is.EqualTo(result));
        }

        [TestCase(20, 10, 10)]
        [TestCase(20, -5, 25)]
        [TestCase(-20, -50, 30)]
        public void Subtract_CorrectResult_WithAccumulator(double accumulator, double b, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Subtract(b), Is.EqualTo(result));
        }

        [TestCase(20, 10, 200)]
        [TestCase(20, -5, -100)]
        [TestCase(-20, -50, 1000)]
        public void Multiply_CorrectResult_WithAccumulator(double accumulator, double b, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Multiply(b), Is.EqualTo(result));
        }

        [TestCase(20, 10, 2)]
        [TestCase(20, -5, -4)]
        [TestCase(-20, -50, 0.4)]
        public void Divide_CorrectResult_WithAccumulator(double accumulator, double b, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Divide(b), Is.EqualTo(result));
        }

        [TestCase(-2, 10, 1024)]
        [TestCase(2, -5, 0.03125)]
        [TestCase(-4, -2, 0.0625)]
        [TestCase(2, 4, 16)]
        [TestCase(-2, -2.5, Double.NaN)]
        public void Power_CorrectResult_WithAccumulator(double accumulator, double b, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Power(b), Is.EqualTo(result));
        }


        [TestCase(3, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        public void Clear_CorrectResult_WithAccumulator(double accumulator, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(10, 10)]
        public void Test_Accumulator(double accumulator, double result)
        {
            _uut.Clear();
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }


        #endregion
    }
}
