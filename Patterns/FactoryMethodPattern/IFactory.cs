// 工場インターフェース

namespace Design_Patterns_C_.Patterns.FactoryMethodPattern
{
    interface IFactory
    {
        // factory method
        public IProduct CreateProduct();
    }
}