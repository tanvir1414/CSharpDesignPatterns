using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com14adapter
{
    public interface IVendor
    {
        void ConnectToDb(string connectionString, string customerId);
        string PrintAge();
    }
}
