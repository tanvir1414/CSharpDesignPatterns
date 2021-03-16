using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._20chainofresponsibilty
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            try{
                int c = a / b;
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("do something");
            }catch (DivideByZeroException e)
            {
                Console.WriteLine("do something");
            }catch (NullReferenceException e)
            {
                Console.WriteLine("do something");
            }
        }
    }
}
