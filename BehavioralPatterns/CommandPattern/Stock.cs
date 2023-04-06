namespace Design_Patterns_C_.BehavioralPatterns.CommandPattern;

public class Stock
{
    private string name = "ABC";
    private int quantity = 10;

    public Stock(string name, int quantity)
    {
        this.name = name;
        this.quantity = quantity;
    }

    public void buy()
    {
        Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] bought");
    }

    public void sell()
    {
        Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] sold");
    }
}