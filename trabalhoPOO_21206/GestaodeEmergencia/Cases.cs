using System;
using System.Collections.Generic;

namespace GestaodeEmergencia
{
    /// <summary>
    /// This class represents a collection of cases
    /// </summary>
    class Cases
    {
        #region VARIABLES
        private List<Case> caseList;
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public Cases()
        {
            caseList = new List<Case>();
        }

        #endregion

        #region PROPERTIES

        public List<Case> CaseList
        {
            get { return caseList; }
        }

        #endregion

        #region OVERRIDES

        // You can add methods here for manipulating the case list, if needed

        #endregion

        #endregion
    }
}
