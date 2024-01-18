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
        public bool AddPatient(string name, GenderType gender, string address, bool infection, int age)
        {
            // Check if a patient with the same name and age already exists
            if (patientList.Any(p => p.Name == name && p.Age == age))
            {
                // Patient with the same name and age already exists, do not add
                return false;
            }

            // Create a new patient and add it to the list
            Patient newPatient = new Patient(name, gender, address, infection, age);
            patientList.Add(newPatient);

            // Patient added successfully
            return true;
        }
        /// <summary>
        /// removes a patient based on their id
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public bool RemovePatient(int patientID)
        {
            // Find the patient with the specified ID
            Patient patientToRemove = patientList.FirstOrDefault(p => p.PatientID == patientID);

            // If the patient is found, remove it from the list
            if (patientToRemove != null)
            {
                patientList.Remove(patientToRemove);
                return true; // Patient removed successfully
            }

            return false; // Patient not found
        }


        /// <summary>
        /// Saves all the patients to a file
        /// </summary>
        /// <param name="filePath">path where the file is stored</param>
        /// <returns></returns>
        public bool SavePatientsToFile(string directoryPath)
        {
            string fileName = "patients_data.txt";

            try
            {
                // Check if the directory exists, and create it if not
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string filePath = Path.Combine(directoryPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var patient in patientList)
                    {
                        string line = $"{patient.Name},{patient.Gender},{patient.Address},{patient.Infection},{patient.Age}";
                        writer.WriteLine(line);
                    }
                }

                return true;
            }
            catch (FileException)
            {
                throw new FileException("Could not save data to file");
            }
        }

        /// <summary>
        /// Loads all the patient information from the file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool LoadPatientsFromFile(string filePath)
        {
            try
            {
                patientList.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] attributes = line.Split(',');

                        Patient newPatient = new Patient(
                            attributes[0],
                            (GenderType)Enum.Parse(typeof(GenderType), attributes[1]),
                            attributes[2],
                            bool.Parse(attributes[3]),
                            int.Parse(attributes[4])
                        );

                        patientList.Add(newPatient);
                    }
                }
                return true;
            }
            catch (FileException)
            {
               throw new FileException("Could not load data from file");
            }
            catch (Exception ex)
            {
                throw new FileException($"An unexpected error ocurred: {{ex.Message}}", ex);
            }
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
