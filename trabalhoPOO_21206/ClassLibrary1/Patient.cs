/*
*	<copyright file="Patient.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description>Creates Patients</description>
**/
using ClassLibrary1;
using ClassLibrary1.Exceptions;
using System;

namespace ClassLibrary1
{
    public class Patient : Person, IComparable<Patient>
    {
        #region ATTRIBUTES
        public static int nextPatientID = 1; // Used to automatically generate unique patient IDs
        private int patientID;
        private string email;
        private bool infection;
        #endregion

        #region METHODS
        /// <summary>
        /// Compare Patient objects to other patients by name
        /// </summary>
        /// <param name="otherPatient"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int CompareTo(Patient otherPatient)
        {
            if (otherPatient == null)
            {
                throw new PatientComparisonException();
            }
            
            if (this.PatientID == otherPatient.PatientID)
            {
                throw new PatientComparisonException("Patients have the same ID.");
            }

            return this.name.CompareTo(otherPatient.name);
        }


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
            //prevent negative ages
            if (age < 0)
            {
                throw new InvalidAgeException();
            }

            patientID = nextPatientID++;
            Name = name;
            Gender = gender;
            Address = address;
            Infection = infection;
            Age = age; 
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// patients ID 
        /// </summary>
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
