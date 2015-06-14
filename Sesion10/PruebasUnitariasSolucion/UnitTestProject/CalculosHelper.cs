using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    public class CalculosHelper
    {
        public CalculosHelper() { }
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        public int Substract(int a, int b)
        {
            int x = a - b;
            return x;
        }

        public int Div(int a, int b)
        {
            int x = a / b;
            return x;
        }

    }
}
