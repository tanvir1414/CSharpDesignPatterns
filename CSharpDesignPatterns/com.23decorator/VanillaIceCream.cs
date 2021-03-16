using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class VanillaIceCream : IceCream
    {
        public override string GetDescription()
        {
            return "Vanilla IceCream";
        }
        public override double Cost()
        {
            return 1.00;
        }
    }
}
