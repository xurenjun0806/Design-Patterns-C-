// Apple時計商品

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

class AppleWatch : IProductWatch
{
    public string GetProductInfo()
    {
        return "私はAppleWatchですよ！";
    }
}