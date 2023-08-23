namespace Crm.DataAccess;

public sealed class Order
{
    public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public OrderState State { get; set; }
    public DeliveryType DeliveryType { get; set; }
}