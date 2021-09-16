
//-----------------------------------------------------------------------
// <copyright file="EngineTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ProductPromotionEngineTest
{
    using ProductPromotionEngine.Interface;
    using ProductPromotionEngine.Model;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;
    using ProductPromotionEngine;

    public class EngineTest
    {
        protected IServiceProvider serviceProvider;
        public EngineTest(ServiceMock service)
        {
            serviceProvider = service.BuildServiceProvider();
        }

        #region TestCalculation
        public static IEnumerable<object[]> TestSetup(int numTests)
        {
            List<Product> products = new List<Product>()
            {
                new Product("A",50),
                new Product("B",30),
                new Product("C",20),
                new Product("D",15),
                new Product("E",10),
                new Product("F",5)

            };
            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion(1, "A", "QTY", 3, 130),
                new Promotion(2, "B", "QTY", 2, 45),
                new Promotion(3, "C", "QTY", 1, 0),
                new Promotion(3, "D", "QTY", 1, 30),
                new Promotion(4,"E", "PERCENT",0,0.5M)
            };

            Order order1 = new Order(1, new List<Cart>() { new Cart("A", 1), new Cart("B", 1), new Cart("C", 1) });
            Order order2 = new Order(2, new List<Cart>() { new Cart("A", 5), new Cart("B", 5), new Cart("C", 1) });
            Order order3 = new Order(3, new List<Cart>() { new Cart("A", 3), new Cart("B", 5), new Cart("C", 1), new Cart("D", 1) });
            Order order4 = new Order(3, new List<Cart>() { new Cart("A", 3), new Cart("B", 5), new Cart("C", 1), new Cart("D", 1), new Cart("E", 2) });
            Order order5 = new Order(4, new List<Cart>() { new Cart("A", 3), new Cart("B", 5), new Cart("C", 1), new Cart("D", 1), new Cart("F", 2) });

            var allData = new List<object[]> {
                new object[] { order1, promotions, products, 100 },
                new object[] { order2, promotions, products, 370 },
                new object[] { order3, promotions, products, 280 },
                new object[] { order4, promotions, products, 290 },
                new object[] { order5, promotions, products, 290 }
            };

            return allData.Take(numTests);
        }

        [Theory]
        [MemberData(nameof(TestSetup), parameters: 5)]
        public void CalcuateTotalOrderPrice(Order order, List<Promotion> promotions, List<Product> products, decimal result)
        {
            IEngine unitOfWork = serviceProvider.GetService<IEngine>();
            ProductPromotionEngineService newObj = new ProductPromotionEngineService(unitOfWork);
            decimal calcValue = newObj.CalculateOrderPrice(order, promotions, products);
            // To check if the calculated and the expected value are same
            Assert.Equal(calcValue, result);
        }
        #endregion
    }
}
