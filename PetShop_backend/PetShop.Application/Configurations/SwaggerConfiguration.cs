using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Application.Configurations
{
    public class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Pet Shop",
                    Description = "BackEnd Application"
                    // Contact = new OpenApiContact() { Name = "Suporte", Email = "suporte@email.com.br" },
                });

            });
        }
    }
}