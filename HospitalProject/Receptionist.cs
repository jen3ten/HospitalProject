using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital2
{
    class Receptionist : Employee
    {
        public bool IsOnThePhone { get; set; }
        public double EmployeeSalary { get; set; }


        public Receptionist(string employeeName, int employeeNumber, bool isOnThePhone) : base(employeeName, employeeNumber, 40000)
        {
            IsOnThePhone = isOnThePhone;
            EmployeeSalary = 45000.00;
        }
        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Is on the phone: " + IsOnThePhone);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + EmployeeSalary);
        }
    }
}
