using ClassLibrary1;

internal class Program
{
    static void Main(string[] args)
    {
        // Create instances of Metrics and other necessary objects
        Metrics metrics = new Metrics();
        AgeMetrics ageMetrics = new AgeMetrics();
        GenderMetrics genderMetrics = new GenderMetrics();
        RegionMetrics regionMetrics = new RegionMetrics();

        // Create a Patients instance
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

        // Create a Cases instance
        Cases caseManager = new Cases();
        // Populate the list of cases
        foreach (var patient in patientManager.GetPatients())
        {
            caseManager.AddCase(patient, DateTime.Now, patient.Infection);
        }

        while (true)
        {

            Console.WriteLine("\n=== Menu ===");
            Console.WriteLine("1. Display Patient Information");
            Console.WriteLine("2. Remove patient by ID");
            Console.WriteLine("3. Display Case Information");
            Console.WriteLine("4. Display Metrics Information");
            Console.WriteLine("5. Save Patients to File");
            Console.WriteLine("6. Load Patients from File");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPatientInformation(patientManager);
                    break;

                case "2":
                    RemovePatient(patientManager);
                    break;

                case "3":
                    DisplayCaseInformation(caseManager);
                    break;

                case "4":
                    DisplayMetricsInformation(caseManager, metrics, ageMetrics, genderMetrics, regionMetrics);
                    break;

                case "5":
                    SavePatientsToFile(patientManager);
                    break;

                case "6":
                    LoadPatientsFromFile(patientManager);
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    private static void DisplayPatientInformation(Patients patientManager)
    {
        Console.WriteLine("\n=== Patient Information ===");
        patientManager.GetPatients().Sort();
        foreach (var patient in patientManager.GetPatients())
        {
            Console.WriteLine($"ID: {patient.PatientID}");
            Console.WriteLine($"Name: {patient.Name}");
            Console.WriteLine($"Gender: {patient.Gender}");
            Console.WriteLine($"Address: {patient.Address}");
            Console.WriteLine($"Age: {patient.Age}");
            Console.WriteLine($"Infection Status: {patient.Infection}\n");
        }
    }
    private static void DisplayCaseInformation(Cases caseManager)
    {
        Console.WriteLine("\n=== Case Information ===");
        foreach (var Case in caseManager.GetCases())
        {
            Console.WriteLine($"CaseID: {Case.CaseId}");
            Console.WriteLine($"InfectedPerson: {Case.InfectedPerson.Name}");
            Console.WriteLine($"Date Confirmed: {Case.DateConfirmed}");
            Console.WriteLine($"Is Infeced: {Case.IsInfected}\n");
        }
    }
    public static void DisplayMetricsInformation(Cases caseManager, Metrics metrics, AgeMetrics ageMetrics, GenderMetrics genderMetrics, RegionMetrics regionMetrics)
    {
        List<Case> cases = caseManager.GetCases();

        // Update metrics based on the patient data
        metrics.UpdateStatistics(cases);
        ageMetrics.UpdateStatistics(cases);
        genderMetrics.UpdateStatistics(cases);
        regionMetrics.UpdateStatistics(cases);

        Console.WriteLine("\n=== Metrics Information ===");

        // Display general metrics information
        Console.WriteLine($"Total Cases: {metrics.TotalCases}");
        Console.WriteLine($"Active Cases: {metrics.ActiveCases}");
        Console.WriteLine($"Recovered Cases: {metrics.RecoveredCases}\n");

        // Check if there are cases for age distribution
        if (ageMetrics.AgeDistribution.Count == 0)
        {
            Console.WriteLine("No cases found for age distribution.");
        }
        else
        {
            // Display age distribution
            Console.WriteLine("Age Distribution:");
            foreach (var ageCountPair in ageMetrics.AgeDistribution)
            {
                Console.WriteLine($"Age: {ageCountPair.Key}, Count: {ageCountPair.Value}");
            }
            Console.WriteLine();
        }

        // Check if there are cases for gender distribution
        if (metrics.TotalCases == 0)
        {
            Console.WriteLine("No cases found for gender distribution.");
        }
        else
        {
            // Display gender distribution
            Console.WriteLine($"Male Cases: {genderMetrics.MalePercentage}%");
            Console.WriteLine($"Female Cases: {genderMetrics.FemalePercentage}%");
            Console.WriteLine($"Non-Binary Cases: {genderMetrics.NonBinaryPercentage}%\n");
        }

        // Check if there are cases for region distribution
        if (regionMetrics.RegionDistribution.Count == 0)
        {
            Console.WriteLine("No cases found for region distribution.");
        }
        else
        {
            // Display region distribution
            Console.WriteLine("Region Distribution:");
            foreach (var regionCountPair in regionMetrics.RegionDistribution)
            {
                Console.WriteLine($"Region: {regionCountPair.Key}, Count: {regionCountPair.Value}");
            }
        }
    }


    private static void SavePatientsToFile(Patients patientManager)
    {
        string directoryPath = "C:\\Users\\defrutas\\Downloads\\TP_POO_21206-main (1)\\TP_POO_21206-main\\trabalhoPOO_21206";

        bool success = patientManager.SavePatientsToFile(directoryPath);

        if (success)
        {
            Console.WriteLine("Patient data has been saved to the file.");
        }
        else
        {
            Console.WriteLine("Error saving patient data.");
        }
    }
    private static void LoadPatientsFromFile(Patients patientManager)
    {
        string filePath = "C:\\Users\\defrutas\\Downloads\\TP_POO_21206-main (1)\\TP_POO_21206-main\\trabalhoPOO_21206\\patients_data.txt";

        bool success = patientManager.LoadPatientsFromFile(filePath);


        if (success)
        {
            Console.WriteLine("Patient data has been loaded from the file.");
        }
        else
        {
            Console.WriteLine("Error loading patient data from the file.");
        }
    }
    private static void RemovePatient(Patients patientManager)
    {
        Console.Write("Enter the ID of the patient to remove: ");

        if (int.TryParse(Console.ReadLine(), out int patientID))
        {
            bool removed = patientManager.RemovePatient(patientID);

            if (removed)
            {
                Console.WriteLine($"Patient with ID {patientID} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Patient with ID {patientID} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid patient ID.");
        }
    }
}
