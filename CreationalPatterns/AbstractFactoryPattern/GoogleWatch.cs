// Google時計商品

namespace Design_Patterns_C_.CreationalPatterns.AbstractFactoryPattern;

class GoogleWatch : IProductWatch
{
    public string GetProductInfo()
    {
        return "私はGoogleWatchですよ！";
    }
}