//-----------------------------------------------------------------------
// <copyright file="Engine.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ProductPromotionEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ProductPromotionEngine.Interface;
    using ProductPromotionEngine.Model;

    /// <summary>
    /// Engine Class.
    /// </summary>
    public class Engine : IEngine
    {
        /// <summary>
        /// Calculate total price for all the porducts in the order.
        /// </summary>
        /// <param name="order">Order details.</param>
        /// <param name="promotions">Promotion details.</param>
        /// <param name="products">Product details.</param>
        /// <returns>Calculated value.</returns>
        public decimal CalculateTotalPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            decimal calcPrice = 0M;

            // loop through the list of products in the Order
            foreach (var orderItem in order.Products)
            {
                // select if there are any promotions to the product in the order
                Promotion prom = promotions.Where(p => p.ProductId == orderItem.ProductId).FirstOrDefault();
                if (prom == null)
                {
                    // if there is no promotions for the product
                    calcPrice += orderItem.OrderQuantity * products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice;
                }
            }
            return calcPrice;
        }
    }
}
