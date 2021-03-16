using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class IceCreamDecorator : IceCream
    {
        IceCream topping;

        protected string seperator = ", ";
         
        public IceCreamDecorator(IceCream topping)
        {
            this.topping = topping;
        }

        public override string GetDescription()
        {
            return topping.GetDescription();
        }
        public override double Cost()
        {
            return topping.Cost();
        }
    }
}
