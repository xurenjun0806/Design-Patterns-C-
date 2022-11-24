// Apple時計商品

namespace Design_Patterns_C_.CreationalPatterns.AbstractFactoryPattern;

class AppleWatch : IProductWatch
{
    public string GetProductInfo()
    {
        return "私はAppleWatchですよ！";
    }
}