using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Bussiness.Exceptions
{
    public class SystemSettingsFailureException : Exception
    {
        public SystemSettingsFailureException(
            string message =
                "The database has no records on system_settings table. Run the sql stored procedure fill_seeds in order to solve this problem.")
            : base(message)
        {
        }
    }
}