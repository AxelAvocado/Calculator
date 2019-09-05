﻿using System;

namespace Cal
{
    public class Calculator
    {
        private double _accumulator = -2;
        public double Add(double a, double b)
        {
            _accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            _accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            _accumulator = a * b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            _accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }

        public double Divide(double a, double b)
        {
            if(b==0)
            {
                throw new Exception();
            }

            return a / b;
        }

        public double Accumulator
        {
            get { return _accumulator; }
            private set { _accumulator = value; }
        }

        public void Clear()
        {
            _accumulator = 0;
        }

        public double Add(double addend)
        {
            _accumulator += addend;
            return _accumulator;
        }
        public double Subtract(double subtractor)
        {
            _accumulator -= subtractor;
            return _accumulator;
        }
        public double Multiply(double multiplier)
        {
            _accumulator = _accumulator * multiplier;
            return _accumulator;
        }

        public double Divide(double divisor)
        {
            if(_accumulator == 0)
            {
                throw new Exception();
            }

            return _accumulator/divisor;

        }

        public double Power(double exponent)
        {
            double test= Math.Pow(_accumulator, exponent);
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
            else if (test == null)
            {
                throw new Exception();
            }
            return Math.Pow(_accumulator, exponent);
        }
    }
}
