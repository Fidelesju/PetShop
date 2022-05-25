using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Application.Configurations
{
    public class DependencyInjectionConfiguration
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
            //services.AddScoped<IDeliveryTaskInitialization, DeliveryTaskInitialization>();
        }

        private static void ConfigureDbsDependencyInjection(IServiceCollection services)
        {
            //services.AddScoped<IRobotSummaryDeliveryDb, RobotSummaryDeliveryDb>();
        }

        private static void ConfigureRepositoriesDependencyInjection(IServiceCollection services)
        {
            // services.AddScoped<IPromoterTrackRepository, PromoterTrackRepository>();
        }

        private static void ConfigureMappersDependencyInjection(IServiceCollection services)
        {
            //services.AddScoped<IPromoterPointCreateMapper, PromoterPointCreateMapper();
        }
    }
}