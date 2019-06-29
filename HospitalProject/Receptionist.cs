using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProject
{
    class Receptionist : Employee
    {
        public bool IsOnThePhone { get; set; }
        

        public Receptionist(string employeeName, int employeeNumber, bool isOnThePhone) : base(employeeName, employeeNumber, 45000)
        {
            IsOnThePhone = isOnThePhone;
           
        }
        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Is on the phone: " + IsOnThePhone);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }
    }
}
