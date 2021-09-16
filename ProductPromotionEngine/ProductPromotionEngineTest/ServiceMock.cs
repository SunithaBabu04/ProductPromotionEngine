//-----------------------------------------------------------------------
// <copyright file="ServiceMock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ProductPromotionEngineTest
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using ProductPromotionEngine;
    using ProductPromotionEngine.Interface;

    /// <summary>
    /// Service Mock.
    /// </summary>
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
