using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._25builder
{
    class Vehicle
    {
        string model;
        int year;

        public Vehicle(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
        public override string ToString()
        {
            return this.model + "(" + this.year + ")";
        }
    }
}
