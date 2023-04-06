namespace Design_Patterns_C_.BehavioralPatterns.CommandPattern;

public class BuyStock : Order
{
    private Stock stock;

    public BuyStock(Stock stock)
    {
        this.stock = stock;
    }

    public void execute()
    {
        stock.buy();
    }
}