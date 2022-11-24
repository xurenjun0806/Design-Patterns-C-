// 工場インターフェース

namespace Design_Patterns_C_.CreationalPatterns.FactoryMethodPattern
{
    interface IFactory
    {
        // factory method
        public IProduct CreateProduct();
    }
}