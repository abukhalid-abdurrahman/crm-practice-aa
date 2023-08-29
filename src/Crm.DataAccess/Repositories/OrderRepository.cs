namespace Crm.DataAccess;

public sealed class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders;
    private long _id = 0;

    public OrderRepository()
    {
        _orders = new List<Order>();   
    }

    public bool Create(Order order)
    {
        throw new NotImplementedException();
    }

    public int GetOrderCount() => _orders.Count;

    public int GetOrderCount(OrderState orderState) => _orders.Count(o => o.State == orderState);

    public bool UpdateOrderState(long orderId, OrderState orderState)
    {
        Order? order = _orders.Find(o => o.Id == orderId);
        if (order is null) return false;
        
        order.State = orderState;

        return true;
    }
}