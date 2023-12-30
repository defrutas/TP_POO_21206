/*
*	<copyright file="Medic.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description> creates medics </description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public enum SpecializationType
{
    CLINICA_GERAL,
    EPIDEMIOLOGIST,
    NURSE,
    INFECTIOUS_DISEASE_SPECIALIST,
    PUBLIC_HEALTH
}

namespace ClassLibrary1
{
    public class Medic : Person
    {
        #region Attributes
        private string email;
        private SpecializationType specialization;
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
            specialization = SpecializationType.NURSE;
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
        public Medic(string name, int age, GenderType gen, string em,SpecializationType spec)
        {
            this.name = name;
            this.age = age;
            gender = gen;
            this.email = em;
            specialization = spec;
        }
        #endregion

        #region Properties
        /// <summary>
        /// email associated to medics
        /// </summary>
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        /// <summary>
        /// display specialization
        /// </summary>
        public SpecializationType Specialization
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
