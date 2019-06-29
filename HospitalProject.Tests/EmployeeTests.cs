using Xunit;
using System;

namespace HospitalProject.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void DrawBloodMethodTest()
        {
            Patient testPatient = new Patient("John");
            Doctor testDoctor = new Doctor("DrTest", 123, "specialty");

            testDoctor.DrawBlood(testPatient);

            Assert.Equal(19, testPatient.BloodLevel);
        }

        [Fact]
        public void CarePatientMethodTest()
        {
            Patient newPatient = new Patient("Don");
            Doctor newDoctor = new Doctor("DrDr", 123, "cardio");

            newDoctor.CarePatient(newPatient);

            Assert.Equal(11, newPatient.HealthLevel);
        }
    }
}
