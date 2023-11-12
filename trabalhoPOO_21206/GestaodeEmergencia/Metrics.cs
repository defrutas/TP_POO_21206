using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeEmergencia
{
    /// <summary>
    /// parent class responsible for tracking infections
    /// </summary>
    class Metrics
    {
        #region ATTRIBUTES
        protected int totCases; //total registered cases
        protected int activeCases;  //active cases
        protected int recoveredCases;   //revovered cases
        #endregion

        #region METHODS

        #region CONSTRUCTORS

        #endregion

        #region PROPERTIES

        public int TotCases
        {
            get { return totCases; }
        }
        public int ActiveCases
        {
            get { return activeCases; }
        }
        public int RecoveredCases
        {
            get { return recoveredCases; }
        }

        #endregion

        #region OVERRIDES

        #endregion

        #endregion
    }

    /// <summary>
    /// metrics by age
    /// </summary>
    class AgeMetrics : Metrics
    {
        #region ATTRIBUTES
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        #endregion

        #endregion    
    }

    /// <summary>
    /// metrics by gender
    /// </summary>
    class GenderMetrics : Metrics
    {
        #region ATTRIBUTES
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        #endregion

        #endregion
    }

    /// <summary>
    /// metrics by region
    /// </summary>
    class RegionMetrics : Metrics
    {
        #region ATTRIBUTES
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        #endregion

        #endregion
    }
}
