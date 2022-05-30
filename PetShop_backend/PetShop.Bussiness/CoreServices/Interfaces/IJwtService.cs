using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces
{
    public interface IJwtService
    {
        string GetJwtToken(string nameIdentifier, string role);
    }
}