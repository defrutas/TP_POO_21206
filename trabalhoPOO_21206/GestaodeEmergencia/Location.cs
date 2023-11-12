using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GestaodeEmergencia
{
    /// <summary>
    /// captures information about the organizational unit for the system
    /// </summary>
    class Location
    {
        #region ATTRIBUTES
        public string name; //name of the location
        public List<Person> people; //store instances of Person associated with this location
        public int population;  //represents the total population of said location
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public Location(string n, int pop)
        {
            name = n;
            people = new List<Person>(); //store instances of Person associated with this location and store them in "people" variable
            population = pop;
        }

        #endregion

        #region PROPERTIES

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public List<Person> People
        {
            set { people = value; }
            get { return people; }
        }
        public int Population
        {
            set { population = value; }
            get { return population; }
        }

        #endregion

        #region OVERRIDES
        #endregion

        #endregion
    }
}
