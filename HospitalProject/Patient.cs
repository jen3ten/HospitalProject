using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital2
{
     public class Patient
    {
        public string PatientName { get; set; }
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }

        public Patient(string patientName)
        {
            PatientName = patientName;
            HealthLevel = 10;
            BloodLevel = 20;
        }


    }
}
