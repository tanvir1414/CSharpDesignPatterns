using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._22composite
{
    interface IEmployee
    {
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
        IEmployee GetChild(int i);
        void Print();

    }
}
