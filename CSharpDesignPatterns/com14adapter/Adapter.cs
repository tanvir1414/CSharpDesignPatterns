using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com14adapter
{
    public class Adapter : IClient
    {
        IVendor vendor;

        public Adapter(IVendor obj)
        {
            this.vendor = obj;
        }

        public string ConnectToFileSystem(string customerId)
        {
            string connectionString = "get from config file";
            vendor.ConnectToDb(connectionString,customerId);
            return vendor.PrintAge();
        }
    }
}
