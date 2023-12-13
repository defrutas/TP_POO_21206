using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeEmergencia
{
    /// <summary>
    /// parent class responsible for tracking infections
    /// </summary>
    class Metrics
    {
        #region ATTRIBUTES
        protected int totalCases;      // total registered cases
        protected int activeCases;     // active cases
        protected int recoveredCases;  // recovered cases
        #endregion

        #region METHODS
        /// <summary>
        /// Takes a list of Person objects named infectedPeople as a parameter and returns void.
        /// Counts the total number of cases, active cases, and recovered cases.
        /// </summary>
        /// <param name="infectedPeople"></param>
        public virtual void UpdateStatistics(List<Case> cases)
        {
            totalCases = cases.Count;
            activeCases = cases.Count(c => c.IsInfected);
            recoveredCases = cases.Count(c => !c.IsInfected);
        }
        #endregion

        #region CONSTRUCTORS

        #endregion

        #region PROPERTIES

        public int TotalCases
        {
            get { return totalCases; }
        }

        public int ActiveCases
        {
            get { return activeCases; }
        }

        public int RecoveredCases
        {
            get { return recoveredCases; }
        }

        #endregion

        #region OVERRIDES

        #endregion
    }


    class AgeMetrics : Metrics
    {
        #region ATTRIBUTES
        private Dictionary<int, int> ageDistribution; // Dictionary to store the count of cases for each age
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public AgeMetrics()
        {
            ageDistribution = new Dictionary<int, int>();
        }

        #endregion

        #region PROPERTIES

        public Dictionary<int, int> AgeDistribution
        {
            get { return ageDistribution; }
        }

        #endregion

        #region OVERRIDES

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
    /// metrics by gender
    /// </summary>
    class GenderMetrics : Metrics
    {
        #region ATTRIBUTES
        private int maleCases;  //cases for male
        private int femaleCases;    //cases for female
        private int nonBinaryCases; //cases for non binary
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public GenderMetrics(int m, int f, int nb)
        {
            maleCases = m;
            femaleCases = f;
            nonBinaryCases = nb;
        }
        #endregion

        #region PROPERTIES
        public int MaleCases
        {
            get { return maleCases; }
        }

        public int FemaleCases
        {
            get { return femaleCases; }
        }

        public int NonBinaryCases
        {
            get { return nonBinaryCases; }
        }
        #endregion

        #region OVERRIDES

        //public override void UpdateStatistics(List<Person> infectedPeople)
        //{
        //    //add specific code relative to gender
        //}

        #endregion

        #endregion
    }

    /// <summary>
    /// Metrics by region
    /// </summary>
    class RegionMetrics : Metrics
    {
        #region ATTRIBUTES
        private Dictionary<string, int> regionDistribution; // Dictionary to store the count of cases for each region
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public RegionMetrics()
        {
            regionDistribution = new Dictionary<string, int>();
        }

        #endregion

        #region PROPERTIES

        public Dictionary<string, int> RegionDistribution
        {
            get { return regionDistribution; }
        }

        #endregion

        #region OVERRIDES

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
