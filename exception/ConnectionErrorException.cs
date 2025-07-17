namespace eshift.exception
{
    public class ConnectionErrorException : Exception
    {
       
        public ConnectionErrorException()
            : base("A database connection error occurred.")
        {
        }

        public ConnectionErrorException(string message)
            : base(message)
        {
        }

        public ConnectionErrorException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
