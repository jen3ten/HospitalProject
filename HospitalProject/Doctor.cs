
using System;
using System.Text;

namespace HospitalProject
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
       

        
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
            Console.WriteLine("Salary: " + base.Salary);
        }

        public override void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 1;
            //Console.WriteLine("The Doctor has drawn blood from the patient.");
            //Console.ReadLine();
        }

        public override void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            //Console.WriteLine("The Doctor has cared for the patient");
            //Console.ReadLine();

        }
    }
}
