using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using ProductPromotionEngine.Interface;
namespace ProductPromotionEngine
{
    public static class ServiceSetupExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IEngine, Engine>();
            return services;
        }
    }
}
