// 具体的な商品B

namespace Design_Patterns_C_.Patterns.SimpleFactoryPattern
{
    class ConcreteProductB : IProduct
    {
        public string GetProductInfo()
        {
            return "私は商品B！";
        }
    }
}