using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._21bridge
{
    class TestBridge
    {
        static void Main(string[] args)
        {
            Department d1 = new Sales(new FullTime());
            d1.AssignEmployee();

            Department d2 = new IT(new FullTime());
            d2.AssignEmployee();

            d2 = new IT(new PartTime());
            d2.AssignEmployee();
        }
    }
}
