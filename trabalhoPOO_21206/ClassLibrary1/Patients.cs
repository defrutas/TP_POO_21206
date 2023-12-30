/*
*	<copyright file="Patients.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description>Patients class, list of patient</description>
**/
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
        /// <summary>
        /// creates a new list of patients
        /// </summary>
        public Patients()
        {
            patientList = new List<Patient>();
        }
        /// <summary>
        /// adds patients to the list
        /// </summary>
        /// <param name="name"></param>
        /// <param gender="gender"></param>
        /// <param address="address"></param>
        /// <param infection="infection"></param>
        /// <param age="age"></param>
        public void AddPatient(string name, GenderType gender, string address, bool infection, int age)
        {
            Patient newPatient = new Patient(name, gender, address, infection, age);
            patientList.Add(newPatient);
        }
        /// <summary>
        /// used to display patients inside the list
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            return patientList;
        }
    }
}
