namespace Design_Patterns_C_.BehavioralPatterns.CommandPattern;

public class Broker
{
    private List<Order> orderList = new List<Order>();

    public void TakeOrder(Order order)
    {
        orderList.Add(order);
    }

    public void PlaceOrders()
    {
        foreach (Order order in orderList)
        {
            order.execute();
        }
        orderList.Clear();
    }
}