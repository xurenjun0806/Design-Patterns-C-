// 具体的な商品A

namespace Design_Patterns_C_.Patterns.SimpleFactoryPattern
{
    class ConcreteProductA : IProduct
    {
        public string GetProductInfo()
        {
            return "私は商品A！";
        }
    }
}