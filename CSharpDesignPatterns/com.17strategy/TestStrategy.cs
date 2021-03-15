using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._17strategy
{
    class TestStrategy
    {
        //Strategy Pattern
        //Behavioral Pattern
        //Enables an algorithm's behavior to be selected at runtime.
        static void Main(string[] args)
        {
            Context context = new Context(new Add());
            int result = context.ExecuteStrategy(5,4);
            Console.WriteLine("Result " + result);

            context = new Context(new Substract());
            result = context.ExecuteStrategy(5, 4);
            Console.WriteLine("Result " + result);

            context = new Context(new Multiply());
            result = context.ExecuteStrategy(5, 4);
            Console.WriteLine("Result " + result);
        }
    }
}
