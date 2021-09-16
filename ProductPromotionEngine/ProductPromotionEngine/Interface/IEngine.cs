
using System.Collections.Generic;
using ProductPromotionEngine.Model;

namespace ProductPromotionEngine.Interface
{
    public interface IEngine
    {
        decimal CalculateTotalPrice(Order order, List<Promotion> promotions, List<Product> products);
    }
}
