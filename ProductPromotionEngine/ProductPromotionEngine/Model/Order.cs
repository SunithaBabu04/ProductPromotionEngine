using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPromotionEngine.Model
{
    public class Order
    {
        public Order(int orderid, List<Cart> products)
        {
            this.OrderId = orderid;
            this.Products = products;
        }
        public int OrderId { get; set; }
        public List<Cart> Products { get; set; }
    }
}
