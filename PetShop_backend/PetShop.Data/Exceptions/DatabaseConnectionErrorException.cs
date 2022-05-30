using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Data.Exceptions
{
   public class DatabaseConnectionErrorException : Exception
    {
        public DatabaseConnectionErrorException(string message, Exception inner) : base(message, inner)
        {
            Console.WriteLine("Failure on connection to database.");
        }
    }
}