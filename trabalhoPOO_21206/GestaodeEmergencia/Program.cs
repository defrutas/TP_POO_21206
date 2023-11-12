﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeEmergencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name: ");
            string name = Console.ReadLine();

            Person p1 = new Person(name, GenderType.MALE, "Guimaraes", true);
            Console.WriteLine("ID: {0}\nName: {1}\nGender: {2}\nAddress: {3}\nInfection Status: {4}\n\n", p1.IDperson, p1.Name, p1.Gender, p1.Address, p1.Infection);
            
            Person p2 = new Person("Joaquim", GenderType.MALE, "Braga", false);
            Console.WriteLine("ID: {0}\nName: {1}\nGender: {2}\nAddress: {3}\nInfection Status: {4}\n\n", p2.IDperson, p2.Name, p2.Gender, p2.Address, p2.Infection);

            Person p3 = new Person("Floribela", GenderType.FEMALE, "Barcelos", false);
            Console.WriteLine("ID: {0}\nName: {1}\nGender: {2}\nAddress: {3}\nInfection Status: {4}\n\n", p3.IDperson, p3.Name, p3.Gender, p3.Address, p3.Infection);

            Person p4 = new Person("Jeorgina", GenderType.FEMALE, "Barcelos", true);
            Console.WriteLine("ID: {0}\nName: {1}\nGender: {2}\nAddress: {3}\nInfection Status: {4}\n\n", p4.IDperson, p4.Name, p4.Gender, p4.Address, p4.Infection);

            //Person p3 = new Person();
            //Console.WriteLine("ID: {0}\nName: {1}\nGender: {2}\nAddress: {3}\nInfection Status: {4}\n\n", p3.IDperson, p3.Name, p3.Gender, p3.Address, p3.Infection);

            // Create an instance of Metrics or a derived class
            Metrics metrics = new Metrics();

            // Create a list of Person objects
            List<Person> infectedPeople = new List<Person>
            {
                new Person("Alice", GenderType.FEMALE, "Address1", true),
                new Person("Bob", GenderType.MALE, "Address2", true),
                new Person("Charlie", GenderType.NONBINARY, "Address3", false),            
            };

            // Update the statistics
            metrics.UpdateStatistics(infectedPeople);

            // Display the results or perform assertions based on your testing framework
            Console.WriteLine($"Total Cases: {metrics.TotCases}");
            Console.WriteLine($"Active Cases: {metrics.ActiveCases}");
            Console.WriteLine($"Recovered Cases: {metrics.RecoveredCases}");
        }
    }
}
