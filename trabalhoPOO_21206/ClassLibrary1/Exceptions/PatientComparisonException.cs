namespace ClassLibrary1.Exceptions
{
    /// <summary>
    /// Custom exception for patient comparison errors
    /// </summary>
    public class PatientComparisonException : ApplicationException
    {
        /// <summary>
        /// Constructor with a message
        /// </summary>
        public PatientComparisonException() : base("An error ocurred during comparison")
        {
        }

        /// <summary>
        /// Constructor with a custom message
        /// </summary>
        /// <param name="message">Custom exception message</param>
        public PatientComparisonException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor with a custom message and inner exception
        /// </summary>
        /// <param name="message">Custom exception message</param>
        /// <param name="innerException">Inner exception</param>
        public PatientComparisonException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
