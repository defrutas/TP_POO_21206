using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// parent class responsible for tracking infections
    /// </summary>
    public class Metrics
    {
        #region ATTRIBUTES
        protected int totalCases;      // total registered cases
        protected int activeCases;     // active cases
        protected int recoveredCases;  // recovered cases
        #endregion

        #region METHODS
        #region CONSTRUCTORS
        /// <summary>
        /// Takes a list of Case objects and updates the metrics based on the provided cases
        /// Counts total number of cases, active cases and recovered cases
        /// </summary>
        public virtual void UpdateStatistics(List<Case> cases)
        {
            totalCases = cases.Count;
            activeCases = cases.Count(c => c.IsInfected);
            recoveredCases = cases.Count(c => !c.IsInfected);
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// read-only property to get total cases
        /// </summary>
        public int TotalCases
        {
            get { return totalCases; }
        }
        /// <summary>
        /// read-only property to get active cases
        /// </summary>
        public int ActiveCases
        {
            get { return activeCases; }
        }
        /// <summary>
        /// read-only property to get recovered cases
        /// </summary>
        public int RecoveredCases
        {
            get { return recoveredCases; }
        }

        #endregion

        #region OVERRIDES

        #endregion

        #endregion
    }

    /// <summary>
    /// Derived from Metrics
    /// Tracking metrics organized by age.
    /// </summary>
    public class AgeMetrics : Metrics
    {
        #region ATTRIBUTES
        private Dictionary<int, int> ageDistribution; // Dictionary to store the count of cases for each age
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Contructor for age distribution
        /// </summary>
        public AgeMetrics()
        {
            ageDistribution = new Dictionary<int, int>();
        }

        #endregion

        #region PROPERTIES
        /// <summary>
        /// Read-only property to get the age distribution dictionary.
        /// </summary>
        public Dictionary<int, int> AgeDistribution
        {
            get { return ageDistribution; }
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override the base class methods to include additional logic for age distribution.
        /// Counts the number of cases for each age
        /// </summary>
        /// <param name="cases"></param>
        public override void UpdateStatistics(List<Case> cases)
        {
            base.UpdateStatistics(cases); // Call the base class method to update total, active, and recovered cases

            // Additional logic for age distribution
            ageDistribution.Clear(); // Clear existing data

            foreach (var c in cases)
            {
                int age = c.InfectedPerson.Age; // Access InfectedPerson property to get the associated Person's age

                if (ageDistribution.ContainsKey(age))
                {
                    ageDistribution[age]++;
                }
                else
                {
                    ageDistribution[age] = 1;
                }
            }
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Derived from Metrics
    /// Tracking metrics organized by age
    /// </summary>
    public class GenderMetrics : Metrics
    {
        #region ATTRIBUTES
        private int maleCases;      //Count of male cases
        private int femaleCases;    //Count of female cases
        private int nonBinaryCases; //Count of nonBinaryCases

        private double malePercentage;      // Percentage of male cases
        private double femalePercentage;    // Percentage of female cases
        private double nonBinaryPercentage; // Percentage of non-binary cases
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor for gender metrics
        /// </summary>
        public GenderMetrics()
        {
            maleCases = 0;
            femaleCases = 0;
            nonBinaryCases = 0;

            malePercentage = 0.0;
            femalePercentage = 0.0;
            nonBinaryPercentage = 0.0;
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Read/Write property to count male cases
        /// </summary>
        public int MaleCases
        {
            get { return maleCases; }
            set { maleCases = value; }
        }
        /// <summary>
        /// Read/Write property to count female cases
        /// </summary>
        public int FemaleCases
        {
            get { return femaleCases; }
            set { femaleCases = value; }
        }
        /// <summary>
        /// Read/Write property to count non-binary cases
        /// </summary>
        public int NonBinaryCases
        {
            get { return nonBinaryCases; }
            set { nonBinaryCases = value; }
        }

        /// <summary>
        /// Read-only property for the percentage of male cases
        /// </summary>
        public double MalePercentage
        {
            get { return malePercentage; }
            private set { malePercentage = value; }
        }

        /// <summary>
        /// Read-only property for the percentage of female cases
        /// </summary>
        public double FemalePercentage
        {
            get { return femalePercentage; }
            private set { femalePercentage = value; }
        }

        /// <summary>
        /// Read-only property for the percentage of non-binary cases
        /// </summary>
        public double NonBinaryPercentage
        {
            get { return nonBinaryPercentage; }
            private set { nonBinaryPercentage = value; }
        }
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Overrides the base class method to include additional logic for updating 
        /// counts based on the gender of infected persons.
        /// </summary>
        /// <param name="cases"></param>
        public override void UpdateStatistics(List<Case> cases)
        {
            foreach (var person in cases.Select(c => c.InfectedPerson))
            {
                GenderType gender = person.Gender;

                switch (gender)
                {
                    case GenderType.MALE:
                        MaleCases++;
                        break;
                    case GenderType.FEMALE:
                        FemaleCases++;
                        break;
                    case GenderType.NONBINARY:
                        NonBinaryCases++;
                        break;
                }
            }

            // Update percentages based on total cases
            int totalCases = cases.Count;

            MalePercentage = CalculatePercentage(MaleCases, totalCases);
            FemalePercentage = CalculatePercentage(FemaleCases, totalCases);
            NonBinaryPercentage = CalculatePercentage(NonBinaryCases, totalCases);
        }
        #endregion

        /// <summary>
        /// ClearMetrics method to reset the counts
        /// </summary>
        private void ClearMetrics()
        {
            MaleCases = 0;
            FemaleCases = 0;
            NonBinaryCases = 0;
        }

        /// <summary>
        /// Calculate percentage based on count and total
        /// </summary>
        /// <param name="count"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private double CalculatePercentage(int count, int total)
        {
            if (total == 0)
                return 0;

            return ((double)count / total) * 100.0;
        }

        #endregion
    }


    /// <summary>
    /// Derived from Metrics
    /// Tracking metrics organized by age
    /// </summary>
    public class RegionMetrics : Metrics
    {
        #region ATTRIBUTES
        private Dictionary<string, int> regionDistribution; // Dictionary to store the count of cases for each region
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// constructor for region metrics
        /// </summary>
        public RegionMetrics()
        {
            regionDistribution = new Dictionary<string, int>();
        }

        #endregion

        #region PROPERTIES
        /// <summary>
        /// Read-only property to get the region distribution dictionary
        /// </summary>
        public Dictionary<string, int> RegionDistribution
        {
            get { return regionDistribution; }
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Overrides the base class method to include additional logic for updating counts
        /// based on the region of infected persons.
        /// </summary>
        /// <param name="cases"></param>
        public override void UpdateStatistics(List<Case> cases)
        {
            base.UpdateStatistics(cases); // Call the base class method to update total, active, and recovered cases

            // Additional logic for region distribution
            regionDistribution.Clear(); // Clear existing data

            foreach (var c in cases)
            {
                string region = c.InfectedPerson.Address; // Access InfectedPerson property to get the associated Person's location

                if (regionDistribution.ContainsKey(region))
                {
                    regionDistribution[region]++;
                }
                else
                {
                    regionDistribution[region] = 1;
                }
            }
        }
        #endregion
        #endregion
    }
}
