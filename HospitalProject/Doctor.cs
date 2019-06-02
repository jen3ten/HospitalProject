using System;
using System.Text;

namespace Hospital2
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public double EmployeeSalary { get; set; }

        
        public Doctor(string employeeName, int employeeNumber, string specialty) : base(employeeName, employeeNumber, 90000)
        {
            Specialty = specialty;
            
        }

        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Specialty: " + Specialty);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + EmployeeSalary);
        }
    }
}
