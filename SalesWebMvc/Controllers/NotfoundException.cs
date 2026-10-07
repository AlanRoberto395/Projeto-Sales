namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class NotfoundException : Exception
    {
        public NotfoundException()
        {
        }

        public NotfoundException(string? message) : base(message)
        {
        }

        public NotfoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}