using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com14adapter
{
    public class TestAdapter
    {
        static void Main(string[] args)
        {
            IClient client = new ClientSystem();
            client.ConnectToFileSystem("1234");
            Console.WriteLine("---------------");

            IVendor vendor = new VendorSystem();
            vendor.ConnectToDb("OracleDb", "1234");
            Console.WriteLine("---------------");

            Adapter adapter = new Adapter(vendor);
            adapter.ConnectToFileSystem("1234");
        }
    }
}
