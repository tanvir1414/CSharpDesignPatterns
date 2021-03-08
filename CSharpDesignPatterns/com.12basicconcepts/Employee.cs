using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._12basicconcepts
{
    class Employee
    {
        private int empId;
        private string empName;
        public double salary { get; set; }
        public int grade { get; set; }
        public string company ="IBM";

        // Destroying default constructor when we feel employee info is need by default
        public Employee(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
        }
    }
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee(100,"Alex");
            obj1.salary = 10000.00;
            Employee obj2 = new Employee(200, "Lynda");



        }
    }
}
