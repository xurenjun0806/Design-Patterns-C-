// Apple商品工場

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

class AppleFactory : IFactory
{
    public IProductPhone CreatePhone()
    {
        return new ApplePhone();
    }
    public IProductWatch CreateWatch()
    {
        return new AppleWatch();
    }
}