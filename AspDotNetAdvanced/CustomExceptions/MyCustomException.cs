namespace AspDotNetAdvanced.CustomExceptions
{
    public class MyCustomException : Exception
    {
        // no property or method

        public MyCustomException() : base()
        {
        }

        public MyCustomException(string message) : base(message)
        {
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
