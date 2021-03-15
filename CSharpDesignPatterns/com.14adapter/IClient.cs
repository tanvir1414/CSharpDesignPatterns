using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._14adapter
{
    public interface IClient
    {
        string ConnectToFileSystem(string customerId);
    }
}
