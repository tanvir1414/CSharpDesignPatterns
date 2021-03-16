using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class GummiesTopping : IceCreamDecorator
    {
        public GummiesTopping(IceCream topping) : base(topping)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + seperator + "Gummies";
        }
        public override double Cost()
        {
            return base.Cost() + .50;
        } 
    }
}
