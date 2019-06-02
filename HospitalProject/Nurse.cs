using System;
using System.Text;

namespace Hospital2
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public double EmployeeSalary { get; set; }

        //public Nurse(string employeeName, int employeeNumber, double salary) : base(employeeName, employeeNumber, salary)
        //{

        //}
        //public Nurse(string employeeName, int employeeNumber) : base(employeeName, employeeNumber, 50000)
        //{

        //}
        public Nurse(string employeeName, int employeeNumber, int numberOfPatients) : base(employeeName, employeeNumber, 50000)
        {
            NumberOfPatients = numberOfPatients;
            EmployeeSalary = 50000.00;

        }
        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Number of Patients: " + NumberOfPatients);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + EmployeeSalary);
        }
    }
}
