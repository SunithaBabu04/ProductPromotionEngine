using ProductPromotionEngine.Interface;
using ProductPromotionEngine.Model;
using System;
using System.Collections.Generic;

namespace ProductPromotionEngine
{
    public class ProductPromotionEngineService
    {
        private readonly IEngine _engine;
        public ProductPromotionEngineService(IEngine engine)
        {
            this._engine = engine;
        }

        public decimal CalculateOrderPrice(Order order, List<Promotion> promotions, List<Product> products)
        {
            return this._engine.CalculateTotalPrice(order, promotions, products);
        }
    }
}
