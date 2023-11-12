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
        protected int totCases; //total registered cases
        protected int activeCases;  //active cases
        protected int recoveredCases;   //revovered cases
        #endregion

        #region METHODS
        /// <summary>
        /// takes a list of Person objects named infected People as parameter and returns void
        /// counts total ammount of cases, active cases and recovered cases
        /// </summary>
        /// <param name="infectedPeople"></param>
        public virtual void UpdateStatistics(List<Person> infectedPeople)
        {
            totCases = infectedPeople.Count;
            activeCases = infectedPeople.Count(person => person.Infection == true);
            recoveredCases = infectedPeople.Count(person => person.Infection == false);
        }
        #region CONSTRUCTORS

        #endregion

        #region PROPERTIES

        public int TotCases
        {
            get { return totCases; }
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

        #endregion
    }

    /// <summary>
    /// metrics by age 
    /// </summary>
    class AgeMetrics : Metrics 
    {
        #region ATTRIBUTES

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        public override void UpdateStatistics(List<Person> infectedPeople)
        {
            //add specific code relative to age
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

        public override void UpdateStatistics(List<Person> infectedPeople)
        {
            //add specific code relative to gender
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// metrics by region
    /// </summary>
    class RegionMetrics : Metrics
    {
        #region ATTRIBUTES
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        public override void UpdateStatistics(List<Person> infectedPeople)
        {
            //add specific code relative to gender
        }
        #endregion

        #endregion
    }
}
