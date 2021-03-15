using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._16facade
{
    public  class Car
    {
        string vin;

        public Car(string vin)
        {
            this.vin = vin;
        }
        public void CheckCarHistory()
        {
            Console.WriteLine("Check carfax report for " + vin);
        }

        public void CheckCarSafety()
        {
            Console.WriteLine("Check safety report for " + vin);
        }

    }
}
