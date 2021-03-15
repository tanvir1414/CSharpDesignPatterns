using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._17strategy
{
    class Substract : IStrategy
    {
        public int execute(int a, int b)
        {
            Console.WriteLine("Called Substract's excute()");
            return a - b;
        }
    }
}
