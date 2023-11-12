using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public enum TipoGender
{
    MALE,   //0
    FEMALE, //1
    NB      //2
}

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
    public class Medico
    {
        #region Attributes
        private string name;
        private int age;
        private TipoGender gender;
        private string postalc;
        private string email;
        private int nif;
        private TipoSpecialization specialization;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Medico()
        {
            name = "Jonas";
            age = 18;
            gender = TipoGender.MALE;
            postalc = "4805-017";
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
        public Medico(string name, int a, TipoGender gen, string pc, string em, int nNIF, TipoSpecialization s)
        {
            this.name = name;
            this.age = a;
            gender = gen;
            this.postalc = pc;
            this.email = em;
            this.nif = nNIF;
            specialization = s;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public TipoGender Gender
        {
            get { return gender; }
        }

        public string PostalC
        {
            set { postalc = value; }
            get { return postalc; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public int NIF
        {
            get { return nif; }
        }

        public TipoSpecialization Specialization
        {
            get { return specialization; }
        }

        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}
