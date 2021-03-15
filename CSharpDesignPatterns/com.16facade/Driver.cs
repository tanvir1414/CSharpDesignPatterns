using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._16facade
{
    public class Driver
    {
        DateTime dob;
        public Driver(DateTime dob)
        {
            this.dob = dob;
        }
        public void CheckDriverDetails()
        {
            Console.WriteLine("Check driver history " + dob.ToString("d"));
        }
    }
}
