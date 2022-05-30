using Microsoft.Extensions.DependencyInjection;
using PetShop_backend.PetShop.Bussiness.CoreServices;
using PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces;

namespace PetShop_backend.PetShop.Application.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterService(this IServiceCollection services)
        {
            ConfigureDbsDependencyInjection(services);
            ConfigureMappersDependencyInjection(services);
            ConfigureRepositoriesDependencyInjection(services);
            ConfigureServicesDependencyInjection(services);
        }    
        private static void ConfigureServicesDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<ILoggerService, LoggerService>();
            services.AddScoped<ICryptographyService, CryptographyService>();
            services.AddScoped<IFileManagementService, FileManagementService>();
            services.AddScoped<IJwtService, JwtService>();

        }

        private static void ConfigureDbsDependencyInjection(IServiceCollection services)
        {
           //services.AddScoped<IRobotSummaryDeliveryDb, RobotSummaryDeliveryDb>();
        }

        private static void ConfigureRepositoriesDependencyInjection(IServiceCollection services)
        {
            //services.AddScoped<IRobotDisassociatedRepository, RobotDisassociatedRepository>();
        }

        private static void ConfigureMappersDependencyInjection(IServiceCollection services)
        {
            //services.AddScoped<IPuduCloudTasksCreateMapper, PuduCloudTasksCreateMapper>();
        }
    }
}