using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum GenderType
{
    MALE,       //0
    FEMALE,     //1
    NONBINARY   //2
}

namespace GestaodeEmergencia
{
    /// <summary>
    /// class to create person objects
    /// </summary>
    class Person
    {
        #region ATTRIBUTES

        private static int nextId = 1;

        private int id_person;  //id to indentify each individual person
        private string name;    //name of the person
        private GenderType gender;  //gender
        private string address; //address
        private bool infected;  //if the person is infected or not


        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// default constructor
        /// </summary>
        public Person()
        {
            id_person = 1;
            name = "John";
            gender = GenderType.MALE;
            address = "Barcelos";
            infected = true;
        }

        /// <summary>
        /// person constructor
        /// </summary>
        /// <param id_person="id"></param>
        /// <param name="name"></param>
        /// <param gender="gen"></param>
        /// <param address="addr"></param>
        /// <param infected="inf"></param>
        public Person(string name, GenderType gen, string addr, bool inf)
        {
            id_person = nextId++;
            this.name = name;
            gender = gen;
            address = addr;
            infected = inf;
        }

        #endregion

        #region PROPERTIES
        public int IDperson
        {
            set { id_person = value; } //EXAMPLE ONLY, id should be automatically added
            get { return id_person; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public GenderType Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public bool Infection
        {
            set { infected = value; }
            get { return infected; }
        }
        #endregion

        #endregion
    }

    class InfectedPerson : Person
    {
        public DateTime InfectionDate { get; set; }
        // Additional properties and methods related to infection
    }

    class RecoveredPerson : Person
    {
        public DateTime RecoveryDate { get; set; }
        // Additional properties and methods related to recovery
    }

    class DeceasedPerson : Person
    {
        public DateTime DeathDate { get; set; }
        // Additional properties and methods related to death
    }
}
