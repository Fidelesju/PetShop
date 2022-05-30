using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Data.Exceptions
{
    public class DatabaseQueryFailureException : Exception
    {
        public DatabaseQueryFailureException(string message, Exception exception) : base(message, exception)
        {
            Console.WriteLine("Failure on query to database.");
        }
    }
}