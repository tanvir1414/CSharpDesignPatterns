using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class TestIceCreamShop
    {
        static void Main(string[] args)
        {
            IceCream chocolate = new ChocolateIceCream();

            chocolate = new NutsTopping(chocolate);
            chocolate = new GummiesTopping(chocolate);
            chocolate = new FudgeTopping(chocolate);

            chocolate.PrintDetails();

        }
    }
}
