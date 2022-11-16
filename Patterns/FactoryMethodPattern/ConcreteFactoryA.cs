// 具体的な工場A（商品Aを作る）

namespace Design_Patterns_C_.Patterns.FactoryMethodPattern
{
    class ConcreteFactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}