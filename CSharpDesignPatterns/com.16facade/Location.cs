using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._16facade
{
    public class Location
    {
        string state;
        public Location(string state)
        {
            this.state = state;
        }

        public void CheckDrivingConditions()
        {
            Console.WriteLine("Get Location information for " + state);
        }


    }
}
