using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces
{
    public interface ILoggerService
    {
        Task LogError(Exception exception, HttpContext context);
        Task LogErrorServicesBackground(Exception exception);
        Task LogInfo(string info);
    }
}