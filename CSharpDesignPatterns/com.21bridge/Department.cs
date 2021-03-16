using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._21bridge
{
    abstract class Department
    {
        protected Employee employee;

        public Department(Employee employee)
        {
            this.employee = employee;
        }
        public abstract void AssignEmployee();

    }
}
