namespace ClassLibrary1.Exceptions
{
    public class FileException : ApplicationException
    {
        public FileException() : base("There was a file error! ")
        {
        }

        public FileException(string s) : base(s) { }

        public FileException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new FileException(e.Message + " - " + s);
        }
    }
}
