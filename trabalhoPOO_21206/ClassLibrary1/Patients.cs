using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Patients
    {
        private List<Patient> patientList;

        public Patients()
        {
            patientList = new List<Patient>();
        }

        public void AddPatient(string name, GenderType gender, string address, bool infection, int age)
        {
            Patient newPatient = new Patient(name, gender, address, infection, age);
            patientList.Add(newPatient);
        }

        public List<Patient> GetPatients()
        {
            return patientList;
        }
    }
}
