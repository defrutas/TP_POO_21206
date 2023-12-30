using System;

namespace ClassLibrary1
{
    /// <summary>
    /// This class represents an individual case of infection
    /// </summary>
    public class Case
    {
        #region VARIABLES
        private static int nextCaseId = 1; // Used to automatically generate unique case IDs
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public Case(Person infectedPerson, DateTime dateConfirmed, bool isInfected)
        {
            CaseId = nextCaseId++;
            InfectedPerson = infectedPerson;
            DateConfirmed = dateConfirmed;
            IsInfected = isInfected;
        }

        #endregion

        #region PROPERTIES

        public int CaseId { get; set; }
        public Person InfectedPerson { get; set; }
        public DateTime DateConfirmed { get; set; }
        public bool IsInfected { get; private set; }
        //public Medic AssignedMedic { get; set; }

        #endregion

        #region OVERRIDES

        //override ToString() if you want a custom string representation of the case

        #endregion

        #endregion
    }
}
