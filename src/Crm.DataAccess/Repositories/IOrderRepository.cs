namespace Crm.DataAccess;

public interface IOrderRepository
{
    bool Create(Order order);
    bool UpdateOrderState(long orderId, OrderState orderState);
    int GetOrderCount();
    int GetOrderCount(OrderState orderState);

    ValueTask<bool> CreateAsync(Order order, CancellationToken token = default);
    ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderState, CancellationToken token = default);
    ValueTask<int> GetOrderCountAsync(CancellationToken token = default);
    ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default);
}
