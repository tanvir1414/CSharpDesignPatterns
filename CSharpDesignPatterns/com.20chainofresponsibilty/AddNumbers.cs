﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._20chainofresponsibilty
{
    public class AddNumbers : IChain
    {
        private IChain nextInChain;

        // Defines the next object to recieve the data 
        // if this one can't use it.
        public void SetNextChain(IChain nextChain)
        {
            this.nextInChain = nextChain;
        }

        // Tries to calculate the data, or passes it
        // to the Object defined in method setNextChain()

        public void Calculate(Numbers request)
        {
            if (request.CalculationWanted == "add")
            {
                Console.WriteLine(request.Number1 + " + " + request.Number2 +
                            (request.Number1 + request.Number2));
            } 
            else
            {
                Console.WriteLine("Not add - pass it on");

                nextInChain.Calculate(request); // Buzi nai
            }
        }

       
    }
}
