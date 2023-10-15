namespace Crm.DataAccess;

public sealed class EfCoreOrderRepository : IOrderRepository
{
    public bool Create(Order order)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> CreateAsync(Order order, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public int GetOrderCount()
    {
        throw new NotImplementedException();
    }

    public int GetOrderCount(OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public bool UpdateOrderState(long orderId, OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}