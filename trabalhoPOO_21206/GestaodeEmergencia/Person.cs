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
    public class Person
    {
        #region ATTRIBUTES

        private static int nextId = 1;
        private string name;    //name of the person
        private GenderType gender;  //gender
        private string address; //address
        private bool infection;  //if the person is infected or not
        private int age;

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// default constructor
        /// </summary>
        public Person()
        {
            IDperson = 1;
            name = "John";
            gender = GenderType.MALE;
            address = "Barcelos";
            age = 18;
            infection = true;
        }

        /// <summary>
        /// person constructor
        /// </summary>
        /// <param id_person="id"></param>
        /// <param name="name"></param>
        /// <param gender="gen"></param>
        /// <param address="addr"></param>
        /// <param infected="inf"></param>
        public Person(string name, GenderType gender, string address, bool infection, int age)
        {
            IDperson = nextId++;
            Name = name;
            Gender = gender;
            Address = address;
            Infection = infection;
            Age = age; // Use the specified age value
        }


        #endregion

        #region PROPERTIES
        public int IDperson { get; private set; }
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
            set { infection = value; }
            get { return infection; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
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
