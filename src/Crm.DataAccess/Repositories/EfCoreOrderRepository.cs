using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccess;

public sealed class EfCoreOrderRepository : IOrderRepository
{
    private readonly CrmDbContext _db;

    public EfCoreOrderRepository(CrmDbContext crmDbContext)
    {
        _db = crmDbContext;
    }

    public EfCoreOrderRepository()
    {
        _db = new();
    }

    public bool Create(Order order)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> CreateAsync(Order order, CancellationToken token = default)
    {
        await _db.Orders.AddAsync(order, token);
        return await _db.SaveChangesAsync(token) > 0;
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
        return new(_db.Orders.CountAsync(token));
    }

    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        return new(_db.Orders.CountAsync(o => o.State == orderState, token));
    }

    public bool UpdateOrderState(long orderId, OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderState, CancellationToken token = default)
    {
        Order order = await _db.Orders.SingleAsync(o => o.Id == orderId, token);
        order.State = orderState;
        return await _db.SaveChangesAsync(token) > 0;
    }
}