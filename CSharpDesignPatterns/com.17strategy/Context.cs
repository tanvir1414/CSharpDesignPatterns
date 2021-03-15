using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._17strategy
{
    class Context
    {
        IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return strategy.Execute(a,b);
            
        }


    }
}
