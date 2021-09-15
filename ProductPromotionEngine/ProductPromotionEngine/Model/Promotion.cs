using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPromotionEngine.Model
{
    public class Promotion
    {
        public Promotion(int promId, string productId, string uom, int qty, decimal price)
        {
            this.PromotionId = promId;
            this.ProductId = productId;
            this.PromotionProductUOM = uom;
            this.PromotionQty = qty;
            this.PromotionPrice = price;
        }
        public int PromotionId { get; set; }
        public string ProductId { get; set; }
        public string PromotionProductUOM { get; set; }
        public int PromotionQty { get; set; }
        public decimal PromotionPrice { get; set; }
    }
}
