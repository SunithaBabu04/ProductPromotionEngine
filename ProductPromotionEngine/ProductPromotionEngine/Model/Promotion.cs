//-----------------------------------------------------------------------
// <copyright file="Promotion.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ProductPromotionEngine.Model
{
    /// <summary>
    /// Promotion Model Class.
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Promotion"/> class.
        /// </summary>
        /// <param name="promId">Promotion Id.</param>
        /// <param name="productId">Product Id.</param>
        /// <param name="uom">Product Unit Of Measure.</param>
        /// <param name="qty">Product Quantity.</param>
        /// <param name="price">Product Price.</param>
        public Promotion(int promId, string productId, string uom, int qty, decimal price)
        {
            this.PromotionId = promId;
            this.ProductId = productId;
            this.PromotionProductUOM = uom;
            this.PromotionQty = qty;
            this.PromotionPrice = price;
        }

        /// <summary>
        /// Gets or sets Promotion Id.
        /// </summary>
        public int PromotionId { get; set; }

        /// <summary>
        /// Gets or sets Product Id.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets Promotion Product UOM.
        /// </summary>
        public string PromotionProductUOM { get; set; }

        /// <summary>
        /// Gets or sets Promotion Quantity.
        /// </summary>
        public int PromotionQty { get; set; }

        /// <summary>
        /// Gets or sets Promotion Price.
        /// </summary>
        public decimal PromotionPrice { get; set; }
    }
}
