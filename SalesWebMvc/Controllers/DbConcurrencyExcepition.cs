namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class DbConcurrencyExcepition : Exception
    {
        public DbConcurrencyExcepition()
        {
        }

        public DbConcurrencyExcepition(string? message) : base(message)
        {
        }

        public DbConcurrencyExcepition(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}