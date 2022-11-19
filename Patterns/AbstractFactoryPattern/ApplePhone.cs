// Apple携帯商品

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

class ApplePhone : IProductPhone
{
    public string GetProductInfo()
    {
        return "私はApplePhoneですよ！";
    }
}