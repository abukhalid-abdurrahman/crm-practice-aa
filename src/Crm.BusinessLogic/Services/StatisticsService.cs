using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class StatisticsService : IStatisticsService
{
    private readonly IOrderRepository _orderRepository;

    public StatisticsService(IOrderRepository  orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public int GetClientsCount()
    {
        throw new NotImplementedException();
    }

    public int GetOrderCount() => _orderRepository.GetOrderCount();

    public int GetOrderCount(OrderState orderState) => _orderRepository.GetOrderCount(orderState);
}