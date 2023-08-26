using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public bool UpdateOrderState(long orderId, OrderState newOrderState)
    {
        return _orderRepository.UpdateOrderState(orderId, newOrderState);
    }
}