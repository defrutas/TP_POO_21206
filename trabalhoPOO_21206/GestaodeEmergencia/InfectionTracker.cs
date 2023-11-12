using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeEmergencia
{
    /// <summary>
    /// this class will list every Person object that is infected, count total ammount of cases, active cases, recovered cases, etc.
    /// should be able to add person, remove person, update statistics, get cases by region and gender, etc
    /// </summary>
    class InfectionTracker
    {
        #region ATTRIBUTES

        private List<Person> infectedPeople; //list to store instances of Person class representing infected people
        private Metrics systemMetrics;  //instance of Metrics class to track system wide metrics

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// contructor of InfectionsTracker
        /// </summary>
        public InfectionTracker()
        {
            infectedPeople = new List<Person>();
            systemMetrics = new Metrics();
        }

        #endregion

        #region PROPERTIES
        public List<Person> InfectedPeople
        {
            get { return infectedPeople; }
        }

        public Metrics SystemMetrics
        {
            get { return systemMetrics; }
        }
        #endregion

        #region OVERRIDES
        #endregion

        #endregion
    }
}
