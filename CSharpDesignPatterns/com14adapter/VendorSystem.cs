using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com14adapter
{
    public class VendorSystem : IVendor
    {
        int age;
        public void ConnectToDb(string connectionString, string customerId)
        {
            Console.WriteLine("Using connectionstring connect to Db " +
                "and fetch age of customer and set age");
            this.age = 40;
          //  return "40";
        }

        public string PrintAge()
        {
            Console.WriteLine("Age = " + age);
            return age + "";
        }
    }
}
