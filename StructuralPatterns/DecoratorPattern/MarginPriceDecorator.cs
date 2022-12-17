// マージンを介する価格(パターンUML図内の「Decorator」)
namespace Design_Patterns_C_.StructuralPatterns.DecoratorPattern;

public abstract class MarginPriceDecorator : Price
{
    protected Price OriginalPrice { get; init; }
    public MarginPriceDecorator(Price originalPrice)
    {
        this.OriginalPrice = originalPrice;
    }
    public virtual decimal GetPrice()
    {
        return this.OriginalPrice.GetPrice();
    }
}