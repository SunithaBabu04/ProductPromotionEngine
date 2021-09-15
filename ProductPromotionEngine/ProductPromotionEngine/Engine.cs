using System;
using System.Collections.Generic;
using System.Text;
using ProductPromotionEngine.Interface;
using ProductPromotionEngine.Model;

namespace ProductPromotionEngine
{
    public class Engine : IEngine
    {
        public decimal CalculateTotalPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            decimal calcPrice = 0M;
            return calcPrice;
        }
    }
}
