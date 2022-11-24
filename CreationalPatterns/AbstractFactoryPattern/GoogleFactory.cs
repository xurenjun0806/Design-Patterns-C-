// Google商品工場

namespace Design_Patterns_C_.CreationalPatterns.AbstractFactoryPattern;

class GoogleFactory : IFactory
{
    public IProductPhone CreatePhone()
    {
        return new GooglePhone();
    }
    public IProductWatch CreateWatch()
    {
        return new GoogleWatch();
    }
}