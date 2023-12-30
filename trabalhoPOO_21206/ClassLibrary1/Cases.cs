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

        public Cases()
        {
            caseList = new List<Case>();
        }

        public void AddCase(Person infectedPerson, DateTime dateConfirmed, bool isInfected)
        {
            Case newCase = new Case(infectedPerson, dateConfirmed, isInfected);
            caseList.Add(newCase);
        }

        public List<Case> GetCases()
        {
            return caseList;
        }
    }
}
