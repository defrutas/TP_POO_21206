using System;
using System.Collections.Generic;

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

            // Create a list of Person objects
            List<Patient> patients = new List<Patient>
            {
                new Patient("Alice", GenderType.FEMALE, "Address1", true, 18),
                new Patient("Bob", GenderType.MALE, "Address2", true, 22),
                new Patient("Charlie", GenderType.NONBINARY, "Address3", false, 22),
                new Patient("Ana", GenderType.FEMALE, "Address4", true, 20),
                new Patient("Flavio", GenderType.MALE, "Address5", false, 23),

                new Patient("Eva", GenderType.FEMALE, "Address1", true, 20),
                new Patient("David", GenderType.MALE, "Address2", false, 21),
                new Patient("Grace", GenderType.FEMALE, "Address3", true, 19),
                new Patient("Hank", GenderType.MALE, "Address4", false, 22),
                new Patient("Isabel", GenderType.FEMALE, "Address5", true, 23),

                new Patient("Jack", GenderType.MALE, "Address1", false, 18),
                new Patient("Karen", GenderType.FEMALE, "Address2", true, 20),
                new Patient("Leo", GenderType.MALE, "Address3", false, 22),
                new Patient("Mia", GenderType.FEMALE, "Address4", true, 21),
                new Patient("Nathan", GenderType.MALE, "Address4", false, 19),

                new Patient("Olivia", GenderType.FEMALE, "Address1", true, 23),
                new Patient("Paul", GenderType.MALE, "Address2", false, 18),
                new Patient("Quinn", GenderType.NONBINARY, "Address3", true, 20),
                new Patient("Ryan", GenderType.MALE, "Address4", false, 19),
                new Patient("Sara", GenderType.FEMALE, "Address5", true, 22),

                new Patient("Thomas", GenderType.MALE, "Address1", false, 23),
                new Patient("Uma", GenderType.FEMALE, "Address2", true, 18),
                new Patient("Vincent", GenderType.MALE, "Address3", false, 21),
                new Patient("Wendy", GenderType.FEMALE, "Address4", true, 20),
                new Patient("Xander", GenderType.MALE, "Address5", false, 19),
            };

            // Display information about each person
            foreach (var patient in patients)
            {
                Console.WriteLine($"ID: {patient.PatientID}");
                Console.WriteLine($"Name: {patient.Name}");
                Console.WriteLine($"Gender: {patient.Gender}");
                Console.WriteLine($"Address: {patient.Address}");
                Console.WriteLine($"Age: {patient.Age}");
                Console.WriteLine($"Infection Status: {patient.Infection}\n");
            }

            // Create cases based on the list of people
            List<Case> cases = new List<Case>();

            // Populate the list of cases
            foreach (var patient in patients)
            {
                Case newCase = new Case(patient, DateTime.Now, patient.Infection);
                cases.Add(newCase);
            }

            foreach (var Case in cases)
            {
                Console.WriteLine($"CaseID: {Case.CaseId}");
                Console.WriteLine($"InfectedPerson: {Case.InfectedPerson}");
                Console.WriteLine($"Date Confirmed: {Case.DateConfirmed}");
                Console.WriteLine($"Is Infeced: {Case.IsInfected}\n");
            }

            // Update the metrics based on the list of cases
            metrics.UpdateStatistics(cases);

            // Display the results
            Console.WriteLine($"Total Cases: {metrics.TotalCases}");
            Console.WriteLine($"Active Cases: {metrics.ActiveCases}");
            Console.WriteLine($"Recovered Cases: {metrics.RecoveredCases}\n");

            // Update the age metrics based on the list of cases
            ageMetrics.UpdateStatistics(cases);

            // Display the age distribution from AgeMetrics
            Console.WriteLine("Age Distribution:");
            foreach (var ageCountPair in ageMetrics.AgeDistribution)
            {
                Console.WriteLine($"Age: {ageCountPair.Key}, Count: {ageCountPair.Value}");
            }
            Console.WriteLine("\n");

            // Assuming 'cases' is a list of Case objects
            genderMetrics.UpdateStatistics(cases);

            // Retrieve the counts
            int maleCases = genderMetrics.MaleCases;
            int femaleCases = genderMetrics.FemaleCases;
            int nonBinaryCases = genderMetrics.NonBinaryCases;

            // Display the gender distribution from genderMetrics
            Console.WriteLine($"Male Cases: {genderMetrics.MaleCases}");
            Console.WriteLine($"Female Cases: {genderMetrics.FemaleCases}");
            Console.WriteLine($"Non-Binary Cases: {genderMetrics.NonBinaryCases}\n");

            // Update the region metrics based on the list of cases
            regionMetrics.UpdateStatistics(cases);

            // Display the region distribution from RegionMetrics
            Console.WriteLine("Region Distribution:");
            foreach (var regionCountPair in regionMetrics.RegionDistribution)
            {
                Console.WriteLine($"Region: {regionCountPair.Key}, Count: {regionCountPair.Value}");
            }
        }
    }
}
