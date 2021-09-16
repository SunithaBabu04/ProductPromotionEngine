//-----------------------------------------------------------------------
// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ProductPromotionEngine.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Order Model Class.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="orderid">Order Id.</param>
        /// <param name="products">Products in Order.</param>
        public Order(int orderid, List<Cart> products)
        {
            this.OrderId = orderid;
            this.Products = products;
        }

        /// <summary>
        /// Gets or sets Order Id.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets Products.
        /// </summary>
        public List<Cart> Products { get; set; }
    }
}
