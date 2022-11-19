// 工場インターフェース

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

interface IFactory
{
    public IProductPhone CreatePhone();
    public IProductWatch CreateWatch();
}