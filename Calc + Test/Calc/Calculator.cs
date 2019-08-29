using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        private static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("5 + 5 = {0}", calc.Add(5, 5));
            Console.WriteLine("5 - 5 = {0}", calc.Subtract(5, 5));
            Console.WriteLine("5 * 5 = {0}", calc.Multiply(5, 5));
            Console.WriteLine("5^5 = {0}", calc.Power(5, 5));
        }
    }
}
