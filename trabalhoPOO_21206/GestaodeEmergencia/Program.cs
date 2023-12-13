using System;
using System.Collections.Generic;

namespace GestaodeEmergencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Metrics and AgeMetrics
            Metrics metrics = new Metrics();
            AgeMetrics ageMetrics = new AgeMetrics();

            // Create a list of Person objects
            List<Person> people = new List<Person>
            {
                new Person("Alice", GenderType.FEMALE, "Address1", 18,true),
                new Person("Bob", GenderType.MALE, "Address2", 21,true),
                new Person("Charlie", GenderType.NONBINARY, "Address3", 18,false),
                new Person("Ana", GenderType.FEMALE, "Address4", 20,true),
                new Person("Flavio", GenderType.MALE, "Address5", 21,false),
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
            foreach (var person in people)
            {
                // Create cases based on the list of people
                Case newCase = new Case(person, DateTime.Now, person.Infection);
                ageMetrics.UpdateStatistics(new List<Case> { newCase });
            }

            // Display the age distribution from AgeMetrics
            Console.WriteLine("Age Distribution:");
            foreach (var ageCountPair in ageMetrics.AgeDistribution)
            {
                Console.WriteLine($"Age: {ageCountPair.Key}, Count: {ageCountPair.Value}");
            }

            // Update the metrics based on the list of cases
            metrics.UpdateStatistics(cases);

            // Display the results
            Console.WriteLine($"Total Cases: {metrics.TotalCases}");
            Console.WriteLine($"Active Cases: {metrics.ActiveCases}");
            Console.WriteLine($"Recovered Cases: {metrics.RecoveredCases}");
        }
    }
}
