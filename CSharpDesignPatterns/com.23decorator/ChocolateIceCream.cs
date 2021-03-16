using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class ChocolateIceCream : IceCream
    {
        public override string GetDescription()
        {
            return "Chocolate IceCream";
        }

        public override double Cost()
        { 
            return 2.00;
        }
    }
}
