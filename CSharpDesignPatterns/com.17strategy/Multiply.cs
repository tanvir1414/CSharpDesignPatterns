using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._17strategy
{
    class Multiply : IStrategy
    {
        public int execute(int a, int b)
        {
            Console.WriteLine("Called Multiply's excute()");
            return a * b;
        }
    }
}
