using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProject
{
    class Janitor : Employee
    {
        public bool IsSweeping { get; set; }
        


        public Janitor(string employeeName, int employeeNumber, bool isSweeping) : base(employeeName, employeeNumber, 40000)
        {
            IsSweeping = isSweeping;
            
        }
        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Sweeping Status: " + IsSweeping);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }
    }
}
