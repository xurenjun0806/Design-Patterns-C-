namespace Design_Patterns_C_.BehavioralPatterns.CommandPattern;

public class SellStock : Order
{
    private Stock stock;

    public SellStock(Stock stock)
    {
        this.stock = stock;
    }

    public void execute()
    {
        stock.sell();
    }
}