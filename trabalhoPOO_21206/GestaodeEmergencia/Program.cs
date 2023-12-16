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
            List<Person> people = new List<Person>
            {
                new Person("Alice", GenderType.FEMALE, "Address1", true, 18),
                new Person("Bob", GenderType.MALE, "Address2", true, 22),
                new Person("Charlie", GenderType.NONBINARY, "Address3", false, 22),
                new Person("Ana", GenderType.FEMALE, "Address4", true, 20),
                new Person("Flavio", GenderType.MALE, "Address5", false, 23),

                new Person("Eva", GenderType.FEMALE, "Address1", true, 20),
                new Person("David", GenderType.MALE, "Address2", false, 21),
                new Person("Grace", GenderType.FEMALE, "Address3", true, 19),
                new Person("Hank", GenderType.MALE, "Address4", false, 22),
                new Person("Isabel", GenderType.FEMALE, "Address5", true, 23),

                new Person("Jack", GenderType.MALE, "Address1", false, 18),
                new Person("Karen", GenderType.FEMALE, "Address2", true, 20),
                new Person("Leo", GenderType.MALE, "Address3", false, 22),
                new Person("Mia", GenderType.FEMALE, "Address4", true, 21),
                new Person("Nathan", GenderType.MALE, "Address4", false, 19),

                new Person("Olivia", GenderType.FEMALE, "Address1", true, 23),
                new Person("Paul", GenderType.MALE, "Address2", false, 18),
                new Person("Quinn", GenderType.NONBINARY, "Address3", true, 20),
                new Person("Ryan", GenderType.MALE, "Address4", false, 19),
                new Person("Sara", GenderType.FEMALE, "Address5", true, 22),

                new Person("Thomas", GenderType.MALE, "Address1", false, 23),
                new Person("Uma", GenderType.FEMALE, "Address2", true, 18),
                new Person("Vincent", GenderType.MALE, "Address3", false, 21),
                new Person("Wendy", GenderType.FEMALE, "Address4", true, 20),
                new Person("Xander", GenderType.MALE, "Address5", false, 19),
            };

            // Display information about each person
            foreach (var person in people)
            {
                Console.WriteLine($"ID: {person.IDperson}");
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Gender: {person.Gender}");
                Console.WriteLine($"Address: {person.Address}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Infection Status: {person.Infection}\n");
            }

            // Create cases based on the list of people
            List<Case> cases = new List<Case>();

            // Populate the list of cases
            foreach (var person in people)
            {
                Case newCase = new Case(person, DateTime.Now, person.Infection);
                cases.Add(newCase);
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
