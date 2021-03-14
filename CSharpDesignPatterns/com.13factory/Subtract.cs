using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._13factory
{
    public class Subtract : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a - b is {0}", a - b);
        }
    }
}
