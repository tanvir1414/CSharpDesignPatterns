using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._22composite
{
    class TestComposite
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Developer("Emp alex", 90000);
            IEmployee emp2 = new Developer("Emp lynda", 100000);

            IEmployee manager1 = new Manager("Manager John", 135000);
            manager1.Add(emp1);
            manager1.Add(emp2);

            IEmployee emp3 = new Manager("Emp Sara", 115000);

            //Employee director
            Manager director = new Manager("Director Sam", 200000);
            director.Add(emp3);
            director.Add(manager1);

            director.Print();


        }
    }
}
