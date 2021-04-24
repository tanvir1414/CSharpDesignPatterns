using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._25builder
{
    class Insurance
    {
        public Driver Driver { get; set; }
        public Location Location { get; set; }
        public Vehicle Vehicle { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return "Insurance has these values " +
                "\nDriver : " + this.Driver + 
                "\nLocation : " + this.Location +
                "\nPrice : " + this.Price;
        }
    }
}
