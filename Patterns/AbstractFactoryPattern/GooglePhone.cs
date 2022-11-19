// Google携帯商品

namespace Design_Patterns_C_.Patterns.AbstractFactoryPattern;

class GooglePhone : IProductPhone
{
    public string GetProductInfo()
    {
        return "私はGooglePhoneですよ！";
    }
}