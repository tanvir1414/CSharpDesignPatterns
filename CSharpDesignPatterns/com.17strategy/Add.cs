using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._17strategy
{
    class Add : IStrategy
    {
        public int execute(int a, int b)
        {
            Console.WriteLine("Called Add's excute()");
            return a + b;
        }
    }
}
