using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._14adapter
{
    public class ClientSystem : IClient
    {
        public string ConnectToFileSystem(string customerId)
        {
            Console.WriteLine("Connects to local.txt file and returns age of customer");
            return "34";
        }
    }
}
