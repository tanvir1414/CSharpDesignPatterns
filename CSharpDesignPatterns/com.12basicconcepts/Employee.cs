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


        //email is a variable type of IEmail
        IEmail email;

        // Destroying default constructor when we feel employee info is need by default
        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.SendEmail();
        }
    }
    class TestEmployee
    {
        static void Main(string[] args)
        {
            IEmail email = new OutlookEmail();
            Employee obj1 = new Employee(100,"Alex", email);
            obj1.salary = 10000.00;
            obj1.NotifyEmployee();

            email = new WebServicesEmail();
            Employee obj2 = new Employee(200, "Lynda", email);
            obj2.NotifyEmployee();



        }
    }
}
