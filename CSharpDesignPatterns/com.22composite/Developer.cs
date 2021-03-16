using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._22composite
{
    //Leaf has no child 
    class Developer:IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Developer(string name,double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public void Add(IEmployee employee)
        {
            //this is leaf node so this method is not applicable to this class
        }

        public void Remove(IEmployee employee)
        {
            //this is leaf node so this method is not applicable to this class
        }

        public IEmployee GetChild(int i)
        {
            //this is leaf node so this method is not applicable to this class
            return null;
        }

        public void Print()
        {
            Console.WriteLine("-------Developer-------");
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Salary = " + Salary);

        }
    }
}
