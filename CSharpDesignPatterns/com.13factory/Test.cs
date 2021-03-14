using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._13factory
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            Console.WriteLine("Enter second number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            Console.WriteLine("Enter Add, Substract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
         //   Divide obj = new Divide();
            obj.Calculate(num1, num2);
        }
    }
}
