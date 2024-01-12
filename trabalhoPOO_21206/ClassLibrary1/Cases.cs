/*
*	<copyright file="Cases.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description> creates list of cases </description>
**/
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// This class represents a collection of cases
    /// </summary>
    public class Cases
    {
        private List<Case> caseList;
        private int caseIdCounter;  // Counter for generating unique Case IDs

        /// <summary>
        /// creates a new list of cases
        /// </summary>
        public Cases()
        {
            caseList = new List<Case>();
        }

        /// <summary>
        /// adds new cases to the list
        /// </summary>
        /// <param infectedPerson="infectedPerson"></param>
        /// <param dateConfirmed="dateConfirmed"></param>
        /// <param isInfected="isInfected"></param>
        public int AddCase(Patient infectedPerson, DateTime dateConfirmed, bool isInfected)
        {
            // Increment the counter for a new unique Case ID
            caseIdCounter++;

            // Create a new Case with the generated Case ID
            Case newCase = new Case(caseIdCounter, infectedPerson, dateConfirmed, isInfected);

            // Add the case to the list
            caseList.Add(newCase);

            // Return the generated Case ID
            return caseIdCounter;
        }

        public Case GetCase(int caseId)
        {
            // Find and return the case with the specified Case ID
            return caseList.FirstOrDefault(c => c.CaseId == caseId);
        }

        /// <summary>
        /// displays the case list
        /// </summary>
        /// <returns></returns>
        public List<Case> GetCases()
        {
            return caseList;
        }
    }
}
