using Microsoft.Extensions.DependencyInjection;
using System;
using ProductPromotionEngine;
using ProductPromotionEngine.Interface;

namespace ProductPromotionEngineTest
{
    public class ServiceMock
    {
        protected IServiceProvider serviceProvider;
        protected IEngine engine;

        public IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddInjection();
            serviceProvider = services.BuildServiceProvider();

            engine = serviceProvider.GetService<IEngine>();
            return serviceProvider;
        }
    }
}
