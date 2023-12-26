using System;

namespace GestaodeEmergencia
{
    class Patient : Person
    {
        #region ATTRIBUTES
        private static int nextPatientID = 1; // Used to automatically generate unique patient IDs
        private int patientID;
        private string email;
        protected bool infection;
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        public Patient()
        {
            patientID = nextPatientID++;
            name = "Felix";
            gender = GenderType.MALE;
            address = "Barcelos";
            age = 19;
            infection = false;
        }

        public Patient(string name, GenderType gender, string address, bool infection, int age)
        {
            patientID = nextPatientID++;
            Name = name;
            Gender = gender;
            Address = address;
            Infection = infection;
            Age = age; // Use the specified age value
        }
        #endregion

        #region PROPERTIES
        public int PatientID { get { return patientID; } }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public bool Infection
        {
            set { infection = value; }
            get { return infection; }
        }

        #endregion

        #endregion
    }
}
