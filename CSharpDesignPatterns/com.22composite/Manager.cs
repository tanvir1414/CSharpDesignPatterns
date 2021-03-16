using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._22composite
{
    class Manager : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        List<IEmployee> employees = new List<IEmployee>();

        public Manager(string name,double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public void Add(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            employees.Remove(employee);
        }

        public IEmployee GetChild(int i)
        {
            return employees[i];
        }

        public void Print()
        {
            Console.WriteLine("---------Manager--------");
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Salary = " + Salary);

            foreach(IEmployee emp in employees)
            {
                emp.Print();
            }
        }

     
    }
}
