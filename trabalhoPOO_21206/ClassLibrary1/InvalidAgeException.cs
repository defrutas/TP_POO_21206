namespace ClassLibrary1
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException() : base("Age must not be a negative number")
        {
        }

        public InvalidAgeException(string s) : base(s) { }

        public InvalidAgeException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new InvalidAgeException(e.Message + " - " + s);
        }
    }
}
