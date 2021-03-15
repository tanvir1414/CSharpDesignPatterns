using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._20chainofresponsibilty
{
    public interface IChain
    {
        // Either solves the problem or passes the data
        // to the next object in the chain

        void Calculate(Numbers request);

        // Defines the next object to recieve the data
        // if this Object can't process it

        void SetNextChain(IChain nextChain);
    }
}
