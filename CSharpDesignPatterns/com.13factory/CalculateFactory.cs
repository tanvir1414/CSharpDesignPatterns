using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._13factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;
            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("substract"))
            {
                obj = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }

            return obj;
        }
    }
}
