using System;
using Xunit;
using ProductPromotionEngine;
using ProductPromotionEngine.Interface;
using ProductPromotionEngine.Model;
namespace ProductPromotionEngineTest
{
    public class EngineTest
    {
        protected IServiceProvider serviceProvider;
        public EngineTest(ServiceMock service)
        {
            serviceProvider = service.BuildServiceProvider();
        }
        [Fact]
        public void CalcuateTotalOrderPrice()
        {

        }
    }
}
