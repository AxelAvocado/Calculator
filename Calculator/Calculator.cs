using System;

namespace Cal
{
    public class Calculator
    {

        #region Add 

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        #endregion

        #region Substract 

        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        #endregion

        #region MULTIPLY

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        #endregion

        #region POWER
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        public double Power(double exponent)
        {
            double test = Math.Pow(Accumulator, exponent);

            if (test == Double.NaN)
            {
                throw new Exception();
            }
            else if (test == Double.NegativeInfinity)
            {
                throw new Exception();
            }
            else if (test == Double.PositiveInfinity)
            {
                throw new Exception();
            }

            return test;
        }


        #endregion POWER

        #region DIVIDE

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception();
            }

            return a / b;
        }

        public double Divide(double divisor)
        {
            if (Accumulator == 0)
            {
                throw new Exception();
            }

            Accumulator = Accumulator / divisor;
            return Accumulator;

        }

        #endregion

        #region Accumulator

        public double Accumulator
        {
            get;
            set;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        #endregion

    }
}
