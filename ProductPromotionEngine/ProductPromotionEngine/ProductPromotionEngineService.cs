//-----------------------------------------------------------------------
// <copyright file="ProductPromotionEngineService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ProductPromotionEngine
{
    using ProductPromotionEngine.Interface;
    using ProductPromotionEngine.Model;
    using System.Collections.Generic;

    /// <summary>
    /// Product Promotion Engine Service.
    /// </summary>
    public class ProductPromotionEngineService
    {
        private readonly IEngine _engine;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPromotionEngineService"/> class.
        /// </summary>
        /// <param name="engine">Interface.</param>
        /// <returns>Service collection object.</returns>
        public ProductPromotionEngineService(IEngine engine)
        {
            this._engine = engine;
        }

        /// <summary>
        /// Calculate order Price.
        /// </summary>
        /// <param name="order">Order details.</param>
        /// <param name="promotions">Promotion details.</param>
        /// <param name="products">Product details.</param>
        /// <returns>Calculated value.</returns>
        public decimal CalculateOrderPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            return this._engine.CalculateTotalPrice(order, promotions, products);
        }
    }
}
