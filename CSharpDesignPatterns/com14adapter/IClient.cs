using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com14adapter
{
    public interface IClient
    {
        string ConnectToFileSystem(string customerId);
    }
}
