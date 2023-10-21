namespace Crm.DataAccess;

public sealed class Order
{
    public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public OrderState State { get; set; }
    public long DeliveryId { get; set; }

    public Client Client { get; set; }
    public Delivery Delivery { get; set; }
}
