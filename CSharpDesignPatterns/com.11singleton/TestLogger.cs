using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._11singleton
{
    class TestLogger
    {
        static void Main(string[] args)
        {
            //   Logger obj1 = new Logger();
            //  Logger obj2 = new Logger();
        //    Logger obj1 = Logger.GetInstance();
         //   Logger obj2 = Logger.GetInstance();

            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine("----Singleton---");

            /* What is Singleton Pattern?
             * if we want to have only one object, when we use the singleton pattern.
             * 
             * Why do we need only one object of a class?
             * 
             * Objects used for logging, device drivers for printers or registry setting need
             * to have only one of a kind. If there are multiple objects we may encounter 
             * problems like incorrect program behavior, inconsistent results etc.
             * jj
             */

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("----Non Singleton---");

            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }

    class Test{
        
    }
}
