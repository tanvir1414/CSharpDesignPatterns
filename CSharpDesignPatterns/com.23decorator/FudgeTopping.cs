using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._23decorator
{
    class FudgeTopping : IceCreamDecorator
    {
        public FudgeTopping(IceCream topping) : base(topping)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + seperator + "Fudge";
        }
        public override double Cost()
        {
            return base.Cost() + .25;
        }
    }
}
