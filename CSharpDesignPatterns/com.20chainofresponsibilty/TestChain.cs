using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._20chainofresponsibilty
{
    class TestChain
    {
        static void Main(string[] args)
        {
            // Define all of objects in the chain
            IChain obj1 = new AddNumbers();
            IChain obj2 = new SubtractNumbers();
            IChain obj3 = new MultiplyNumbers();
            IChain obj4 = new DivideNumbers();

            // Tell each objeect where to forward the
            // data if it can't process the request
            // establishing the link
            obj1.SetNextChain(obj2);
            obj2.SetNextChain(obj3);
            obj3.SetNextChain(obj4);

            // Define the data in the Numbers Object
            // and send it to the first Object in the chain

            Numbers request = new Numbers(4, 2, "multiply");

            obj1.Calculate(request);


        }
    }
}
