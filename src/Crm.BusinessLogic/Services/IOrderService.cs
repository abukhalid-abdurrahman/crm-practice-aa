using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IOrderService
{
    bool UpdateOrderState(long orderId, OrderState newOrderState);
}