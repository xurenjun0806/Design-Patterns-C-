// 仕入れ価格の 2 倍の値段を提示する(パターンUML図内の「ConcreteDecorator」)
namespace Design_Patterns_C_.StructuralPatterns.DecoratorPattern;

public class DoublePrice : MarginPriceDecorator
{
    public DoublePrice(Price originalPrice) : base(originalPrice){}

    public override decimal GetPrice()
    {
        return this.OriginalPrice.GetPrice() * 2;
    }
}