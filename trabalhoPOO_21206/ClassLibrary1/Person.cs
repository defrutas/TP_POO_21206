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

namespace ClassLibrary1
{
    /// <summary>
    /// class to create person objects
    /// </summary>
    public class Person
    {
        #region ATTRIBUTES
        protected static int nextId = 1;
        protected string name;    //name of the person
        protected GenderType gender;  //gender
        protected string address; //address
        protected int age;

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

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        
        #endregion

        #endregion
    }
}
