// 具体的な商品B

namespace Design_Patterns_C_.Patterns.FactoryMethodPattern
{
    class ConcreteProductB : IProduct
    {
        public string GetProductInfo()
        {
            return "私は商品B！";
        }
    }
}