using System;

namespace ClassLibrary1
{
    public class Patient : Person
    {
        #region ATTRIBUTES
        private static int nextPatientID = 1; // Used to automatically generate unique patient IDs
        private int patientID;
        private string email;
        protected bool infection;
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// default patient constructor
        /// </summary>
        public Patient()
        {
            patientID = nextPatientID++;
            name = "Felix";
            gender = GenderType.MALE;
            address = "Barcelos";
            age = 19;
            infection = false;
        }
        /// <summary>
        /// patient constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param gender="gender"></param>
        /// <param address="address"></param>
        /// <param infection="infection"></param>
        /// <param age="age"></param>
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
        /// <summary>
        /// patients ID 
        /// </summary>
        #region PROPERTIES
        public int PatientID { get { return patientID; } }
        /// <summary>
        /// patients email address
        /// </summary>
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        /// <summary>
        /// patients infection state, true or false
        /// </summary>
        public bool Infection
        {
            set { infection = value; }
            get { return infection; }
        }

        #endregion

        #endregion
    }
}
