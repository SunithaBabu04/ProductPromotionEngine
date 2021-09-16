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
                // check if there are any promotions for the product in the order
                if (!promotions.Where(p => p.ProductId == orderItem.ProductId).Any())
                {
                    // if there is no promotions for the product
                    calcPrice += orderItem.OrderQuantity * products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice;
                }
                else
                {
                    //if there are promotions for the porduct
                    Promotion prom = promotions.Where(p => p.ProductId == orderItem.ProductId).FirstOrDefault();
                    // if there is a single entry in promotions for the porduct
                    if (promotions.Where(p => p.PromotionId == prom.PromotionId).Count() == 1)
                    {
                        // apply promotion price for quantities in promotion, for the rest of the product, apply product price, different calculations for QTY/PERCENT
                        calcPrice += prom.PromotionProductUOM == "QTY" 
                            ? ((orderItem.OrderQuantity / prom.PromotionQty) * prom.PromotionPrice) + ((orderItem.OrderQuantity % prom.PromotionQty) * products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice)
                            : orderItem.OrderQuantity * (products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice - (products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice * prom.PromotionPrice));
                    }
                    else
                    {
                        // if there is a multiplce entry in promotions for the porduct, like bundle , C + D
                        List<Cart> orderBundle = order.Products
                            .Where(p => promotions
                            .Where(p => p.PromotionId == prom.PromotionId)
                            .Select(p => p.ProductId)
                            .ToList()
                            .Contains(p.ProductId))
                            .ToList();
                        if (orderBundle.Count > 1)
                        {
                            foreach (var b in orderBundle)
                            {
                                if (b.OrderQuantity == promotions.Where(p => p.ProductId == b.ProductId).Select(p => p.PromotionQty).FirstOrDefault())
                                {
                                    calcPrice += promotions.Where(p => p.ProductId == prom.ProductId).Select(p => p.PromotionPrice).FirstOrDefault() * b.OrderQuantity;
                                }
                                break;
                            }
                        }
                        else
                        {
                            calcPrice += orderItem.OrderQuantity * products.FirstOrDefault(p => p.ProductId == orderItem.ProductId).ProductPrice;
                        }
                    }
                }
            }
            return calcPrice;
        }
    }
}
