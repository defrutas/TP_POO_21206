using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public enum TipoSpecialization
{
    CLINICA_GERAL,
    EPIDEMIOLOGIST,
    NURSE,
    INFECTIOUS_DISEASE_SPECIALIST,
    PUBLIC_HEALTH
}

namespace GestaodeEmergencia
{
    public class Medic : Person
    {
        #region Attributes
        private string email;
        private TipoSpecialization specialization;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Medic()
        {
            name = "Jonas";
            age = 43;
            gender = GenderType.MALE;
            email = "jonas@medic.com";
            specialization = TipoSpecialization.NURSE;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param age="a"></param>
        /// <param gender="gen"></param>
        /// <param postcode="pc"></param>
        /// <param email="em"></param>
        /// <param NIF="nNIF"></param>
        /// <param specialization="s"></param>
        public Medic(string name, int age, GenderType gen, string em,TipoSpecialization spec)
        {
            this.name = name;
            this.age = age;
            gender = gen;
            this.email = em;
            specialization = spec;
        }
        #endregion

        #region Properties
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public TipoSpecialization Specialization
        {
            get { return specialization; }
        }

        /// <summary>
        /// list of assigned cases to the medic
        /// </summary>
        private List<Case> assignedCases;

        /// <summary>
        /// adds cases assigned to the medic
        /// </summary>
        /// <param name="assignedCase"></param>
        public void AddAssignedCase(Case assignedCase)
        {
            assignedCases.Add(assignedCase);
        }

        /// <summary>
        /// removes cases assigned to the medic
        /// </summary>
        /// <param name="assignedCase"></param>
        public void RemoveAssignedCase(Case assignedCase)
        {
            assignedCases.Remove(assignedCase);
        }

        /// <summary>
        /// gets the assigned cases from the list
        /// </summary>
        /// <returns></returns>
        public List<Case> GetAssignedCases()
        {
            return assignedCases;
        }
        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}
