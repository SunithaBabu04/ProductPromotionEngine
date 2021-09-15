using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPromotionEngine.Model
{
    public class Product
    {
        public Product(string productId, decimal price)
        {
            this.ProductId = productId;
            this.ProductPrice = price;
        }
        public string ProductId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
