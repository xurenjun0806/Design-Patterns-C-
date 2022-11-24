// 具体的な商品A

namespace Design_Patterns_C_.CreationalPatterns.FactoryMethodPattern
{
    class ConcreteProductA : IProduct
    {
        public string GetProductInfo()
        {
            return "私は商品A！";
        }
    }
}