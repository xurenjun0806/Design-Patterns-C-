// Google時計商品

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

class GoogleWatch : IProductWatch
{
    public string GetProductInfo()
    {
        return "私はGoogleWatchですよ！";
    }
}