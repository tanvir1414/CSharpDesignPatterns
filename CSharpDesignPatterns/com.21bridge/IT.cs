using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._21bridge
{
    class IT:Department
    {
        public IT(Employee employee)
            : base(employee) // what does it mean  
        {

        }

        public override void AssignEmployee()
        {
            Console.Write("IT dept assigned");
            employee.EmpType();
        }
    }
}
