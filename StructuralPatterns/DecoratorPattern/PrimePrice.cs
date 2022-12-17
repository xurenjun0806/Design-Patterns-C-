// 原価を表すクラス(パターンUML図内の「ConcreteComponent」)
namespace Design_Patterns_C_.StructuralPatterns.DecoratorPattern;

public class PrimePrice : Price
{
    private decimal Value { get; init; }
    public PrimePrice(decimal value)
    {
        this.Value = value;
    }
    public decimal GetPrice()
    {
        return this.Value;
    }
}