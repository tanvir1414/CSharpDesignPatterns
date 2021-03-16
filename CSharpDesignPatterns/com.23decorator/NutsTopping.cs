using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class NutsTopping : IceCreamDecorator
    {
        public NutsTopping(IceCream topping) : base(topping)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() +seperator +"Nuts";
        }
        public override double Cost()
        {
            return base.Cost() + .75;
        }
    }
}
