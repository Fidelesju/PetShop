using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Data.ApplicationModels
{
     public class PersistenceError
    {
        public string[] Keys { get; set; }
        public string Field { get; set; }
        public string Message { get; set; }
    }
}