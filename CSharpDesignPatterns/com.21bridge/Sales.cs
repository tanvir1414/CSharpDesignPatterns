using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._21bridge
{
    class Sales : Department
    {
        public Sales(Employee employee) : base(employee) // what does it mean  
        {

        }

        public override void AssignEmployee()
        {
            Console.Write("Sales dept assigned");
            employee.EmpType();
        }
    }
}
