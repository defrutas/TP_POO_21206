/*
*	<copyright file="case.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description> creates diferent cases </description>
**/
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
        /// <summary>
        /// case constructor
        /// </summary>
        /// <param infectedPerson="infectedPerson"></param>
        /// <param dateConfirmed="dateConfirmed"></param>
        /// <param isInfected="isInfected"></param>
        public Case(int caseId, Person name, DateTime dateConfirmed, bool isInfected)
        {
            CaseId = caseId;
            InfectedPerson = name;
            DateConfirmed = dateConfirmed;
            IsInfected = isInfected;
        }

        #endregion

        #region PROPERTIES

        public int CaseId { get; private set; } //case id
        public Person InfectedPerson { get; set; } // infected person
        public DateTime DateConfirmed { get; set; } // current date for the confirmation
        public bool IsInfected { get; private set; } // if the person is infected
        public Medic AssignedMedic { get; set; } // assigned medic

        #endregion
        #endregion
    }
}
