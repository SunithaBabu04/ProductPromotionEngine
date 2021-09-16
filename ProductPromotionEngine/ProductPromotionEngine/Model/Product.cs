//-----------------------------------------------------------------------
// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ProductPromotionEngine.Model
{
    /// <summary>
    /// Product Model Class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="productId">Product Id.</param>
        /// <param name="price">Product Price.</param>
        public Product(string productId, decimal price)
        {
            this.ProductId = productId;
            this.ProductPrice = price;
        }

        /// <summary>
        /// Gets or sets Product Id.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets Product Price.
        /// </summary>
        public decimal ProductPrice { get; set; }
    }
}
