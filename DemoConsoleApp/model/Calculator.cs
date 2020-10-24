using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Calculator
    {
        public delegate int Calculation(int a, int b);

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int mul(int a, int b)
        {
            return a * b;
        }

        public static double divide(int a, int b)
        {
            return (double)a / b;
        }

    }
}
