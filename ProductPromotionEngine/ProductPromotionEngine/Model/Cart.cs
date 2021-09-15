using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPromotionEngine.Model
{
    public class Cart
    {
        public Cart(string productId, int orderQty)
        {
            this.ProductId = productId;
            this.OrderQuantity = orderQty;
        }
        public string ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }
}
