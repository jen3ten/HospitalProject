
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
            EmployeeSalary = 90000;

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

        public override void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 1;
            Console.WriteLine("The Doctor has drawn blood from the patient.");
            Console.ReadLine();
        }

        public override void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            Console.WriteLine("The Doctor has cared for the patient");
            Console.ReadLine();

        }
    }
}
