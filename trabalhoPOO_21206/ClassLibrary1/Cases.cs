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
        public void AddCase(Patient infectedPerson, DateTime dateConfirmed, bool isInfected)
        {
            Case newCase = new Case(infectedPerson, dateConfirmed, isInfected);
            caseList.Add(newCase);
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
