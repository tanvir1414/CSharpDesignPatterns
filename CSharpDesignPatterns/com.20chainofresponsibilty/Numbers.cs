using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._20chainofresponsibilty
{
    public class Numbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string CalculationWanted { get; set; }

        public Numbers(int newNumber1, int newNumber2, string calcWanted)
        {
            this.Number1 = newNumber1;
            this.Number2 = newNumber2;
            this.CalculationWanted = calcWanted; 
        }

    }
}
