/*
*	<copyright file="program.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description> Main </description>
**/
using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace GestaodeEmergencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Metrics
            Metrics metrics = new Metrics();
            AgeMetrics ageMetrics = new AgeMetrics();
            GenderMetrics genderMetrics = new GenderMetrics();
            RegionMetrics regionMetrics = new RegionMetrics();

            
            Patients patientManager = new Patients();
            #region PATIENTS LIST
            patientManager.AddPatient("Alice", GenderType.FEMALE, "Address1", true, 18);
            patientManager.AddPatient("Bob", GenderType.MALE, "Address2", true, 22);
            patientManager.AddPatient("Charlie", GenderType.NONBINARY, "Address3", false, 22);
            patientManager.AddPatient("Ana", GenderType.FEMALE, "Address4", true, 20);
            patientManager.AddPatient("Flavio", GenderType.MALE, "Address5", false, 23);

            patientManager.AddPatient("Eva", GenderType.FEMALE, "Address1", true, 20);
            patientManager.AddPatient("David", GenderType.MALE, "Address2", false, 21);
            patientManager.AddPatient("Grace", GenderType.FEMALE, "Address3", true, 19);
            patientManager.AddPatient("Hank", GenderType.MALE, "Address4", false, 22);
            patientManager.AddPatient("Isabel", GenderType.FEMALE, "Address5", true, 23);

            patientManager.AddPatient("Jack", GenderType.MALE, "Address1", false, 18);
            patientManager.AddPatient("Karen", GenderType.FEMALE, "Address2", true, 20);
            patientManager.AddPatient("Leo", GenderType.MALE, "Address3", false, 22);
            patientManager.AddPatient("Mia", GenderType.FEMALE, "Address4", true, 21);
            patientManager.AddPatient("Nathan", GenderType.MALE, "Address4", false, 19);

            patientManager.AddPatient("Olivia", GenderType.FEMALE, "Address1", true, 23);
            patientManager.AddPatient("Paul", GenderType.MALE, "Address2", false, 18);
            patientManager.AddPatient("Quinn", GenderType.NONBINARY, "Address3", true, 20);
            patientManager.AddPatient("Ryan", GenderType.MALE, "Address4", false, 19);
            patientManager.AddPatient("Sara", GenderType.FEMALE, "Address5", true, 22);

            patientManager.AddPatient("Thomas", GenderType.MALE, "Address1", false, 23);
            patientManager.AddPatient("Uma", GenderType.FEMALE, "Address2", true, 18);
            patientManager.AddPatient("Vincent", GenderType.MALE, "Address3", false, 21);
            patientManager.AddPatient("Wendy", GenderType.FEMALE, "Address4", true, 20);
            patientManager.AddPatient("Xander", GenderType.MALE, "Address5", false, 19);
            #endregion
            
            // Display information about each person
            foreach (var patient in patientManager.GetPatients())
            {
                Console.WriteLine($"ID: {patient.PatientID}");
                Console.WriteLine($"Name: {patient.Name}");
                Console.WriteLine($"Gender: {patient.Gender}");
                Console.WriteLine($"Address: {patient.Address}");
                Console.WriteLine($"Age: {patient.Age}");
                Console.WriteLine($"Infection Status: {patient.Infection}\n");
            }


            Cases caseManager = new Cases();

            // Populate the list of cases
            foreach (var patient in patientManager.GetPatients())
            {
                caseManager.AddCase(patient, DateTime.Now, patient.Infection);
            }

            foreach (var Case in caseManager.GetCases())
            {
                Console.WriteLine($"CaseID: {Case.CaseId}");
                Console.WriteLine($"InfectedPerson: {Case.InfectedPerson.PatientName}");
                Console.WriteLine($"Date Confirmed: {Case.DateConfirmed}");
                Console.WriteLine($"Is Infeced: {Case.IsInfected}\n");
            }

            // Create a list of Medics
            List<Medic> medics = new List<Medic>
            {
                new Medic("Fernando", 34, GenderType.MALE, "fernando@medic.com", SpecializationType.CLINICA_GERAL),
                new Medic("Dr. Johnson", 28, GenderType.MALE,"johnson@medic.com", SpecializationType.PUBLIC_HEALTH),
                new Medic("Filipa", 30, GenderType.FEMALE, "medic3@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Joao", 40, GenderType.MALE, "medic4@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Rita", 36, GenderType.FEMALE, "medic5@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Ricardo", 45, GenderType.MALE, "medic6@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Joana", 39, GenderType.FEMALE, "medic7@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Tiago", 32, GenderType.MALE, "medic8@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Diana", 41, GenderType.FEMALE, "medic9@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Marco", 37, GenderType.MALE, "medic10@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Mariana", 31, GenderType.FEMALE, "medic11@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Flavio", 42, GenderType.MALE, "medic12@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Adneiza", 38, GenderType.FEMALE, "medic13@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Ezequiel", 33, GenderType.MALE, "medic14@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Ana", 44, GenderType.FEMALE, "medic15@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Diogo", 29, GenderType.MALE, "medic16@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Beatriz", 43, GenderType.FEMALE, "medic17@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Filipe", 35, GenderType.MALE, "medic18@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Ines", 46, GenderType.FEMALE, "medic19@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Fabio", 27, GenderType.MALE, "medic20@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Maria", 47, GenderType.FEMALE, "medic21@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Bernardo", 26, GenderType.MALE, "medic22@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Georgina", 48, GenderType.FEMALE, "medic23@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Leopoldo", 25, GenderType.MALE, "medic24@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
                new Medic("Vania", 50, GenderType.FEMALE, "medic25@medic.com", SpecializationType.INFECTIOUS_DISEASE_SPECIALIST),
            };

            // Create an instance of MedicAssignment
            MedicAssignment medicManager = new MedicAssignment(medics);

            // Assign medics to existing cases
            medicManager.AssignMedics(caseManager.GetCases());

            // Display assigned medics
            foreach (var Case in caseManager.GetCases())
            {
                Console.WriteLine($"CaseID: {Case.CaseId}");
                Console.WriteLine($"InfectedPerson: {Case.InfectedPerson.PatientName}");
                Console.WriteLine($"Date Confirmed: {Case.DateConfirmed}");
                Console.WriteLine($"Is Infeced: {Case.IsInfected}");
                Console.WriteLine($"Assigned Medic: {Case.AssignedMedic.Name}\n");
            }



            // Update the metrics based on the list of cases
            metrics.UpdateStatistics(caseManager.GetCases());

            // Display the results
            Console.WriteLine($"\nTotal Cases: {metrics.TotalCases}");
            Console.WriteLine($"Active Cases: {metrics.ActiveCases}");
            Console.WriteLine($"Recovered Cases: {metrics.RecoveredCases}\n");

            // Update the age metrics based on the list of cases
            ageMetrics.UpdateStatistics(caseManager.GetCases());

            // Display the age distribution from AgeMetrics
            Console.WriteLine("Age Distribution:");
            foreach (var ageCountPair in ageMetrics.AgeDistribution)
            {
                Console.WriteLine($"Age: {ageCountPair.Key}, Count: {ageCountPair.Value}");
            }
            Console.WriteLine("\n");

            // Assuming 'cases' is a list of Case objects
            genderMetrics.UpdateStatistics(caseManager.GetCases());

            // Retrieve the counts
            int maleCases = genderMetrics.MaleCases;
            int femaleCases = genderMetrics.FemaleCases;
            int nonBinaryCases = genderMetrics.NonBinaryCases;

            // Display the gender distribution from genderMetrics
            Console.WriteLine($"Male Cases: {genderMetrics.MalePercentage}%");
            Console.WriteLine($"Female Cases: {genderMetrics.FemalePercentage}%");
            Console.WriteLine($"Non-Binary Cases: {genderMetrics.NonBinaryPercentage}%\n");

            // Update the region metrics based on the list of cases
            regionMetrics.UpdateStatistics(caseManager.GetCases());

            // Display the region distribution from RegionMetrics
            Console.WriteLine("Region Distribution:");
            foreach (var regionCountPair in regionMetrics.RegionDistribution)
            {
                Console.WriteLine($"Region: {regionCountPair.Key}, Count: {regionCountPair.Value}");
            }
        }
    }
}
