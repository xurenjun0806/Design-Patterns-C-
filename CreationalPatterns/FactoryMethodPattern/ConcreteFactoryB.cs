// 具体的な工場B（商品Bを作る）

namespace Design_Patterns_C_.CreationalPatterns.FactoryMethodPattern
{
    class ConcreteFactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}