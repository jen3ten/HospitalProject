using System;
using System.Text;
using System.Collections.Generic;


namespace HospitalProject
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public double Salary { get; set; }
        public bool PaidYet { get; set; }


        public Employee(string employeeName, int employeeNumber, double salary)
        {
            EmployeeName = employeeName;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            PaidYet = false;
        }

        public virtual void PrintEmployee()
        {

            Console.WriteLine("--------");
            Console.WriteLine("Name: " + EmployeeName);
            Console.WriteLine("Number: " + EmployeeNumber);


        }
        public virtual void PayEmployee()
        {
            if (this.PaidYet != true)
            {
                Console.WriteLine("--------");
                Console.WriteLine("You have paid this employee");
                Console.WriteLine("Name: " + EmployeeName);
                Console.WriteLine("Number: " + EmployeeNumber);
                this.PaidYet = true;
            }
            else
            {
                Console.WriteLine("--------");
                Console.WriteLine("You have already paid this employee");
                Console.WriteLine("Name: " + EmployeeName);
                Console.WriteLine("Number: " + EmployeeNumber);
            }
            Console.WriteLine("Salary: " + this.Salary);


        }

        public virtual void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 1;
            Console.WriteLine("The Doctor has drawn blood from the patient.");
        }

        public virtual void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            Console.WriteLine("The Doctor has cared for the patient");

        }
    }
}
