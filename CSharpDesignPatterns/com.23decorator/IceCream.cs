using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    abstract class IceCream
    {
        public abstract string GetDescription();
        public abstract double Cost();

        public void PrintDetails()
        {
            Console.WriteLine(" Cost : " + this.Cost() +", Desciption : " +this.GetDescription());
        }
    }
}
