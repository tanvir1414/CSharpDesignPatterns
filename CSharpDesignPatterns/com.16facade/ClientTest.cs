using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._16facade
{
    class ClientTest
    {
        static void Main(string[] args)
        {
            InsuraceFacade obj = new InsuraceFacade("1234", DateTime.Parse("1/1/1980"), "DC");
            obj.GetQuote();

        }
    }
}
