//-----------------------------------------------------------------------
// <copyright file="Cart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ProductPromotionEngine.Model
{
    /// <summary>
    /// Cart Model Class.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        /// <param name="productId">Product Id.</param>
        /// <param name="orderQty">Order Quantity.</param>
        public Cart(string productId, int orderQty)
        {
            this.ProductId = productId;
            this.OrderQuantity = orderQty;
        }

        /// <summary>
        /// Gets or sets Product Id.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets Order Quantity.
        /// </summary>
        public int OrderQuantity { get; set; }
    }
}
