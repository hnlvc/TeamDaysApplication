namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class CreateShipFromStoreOrderRequestModel
{
    public CreateOrderConsumerModel Consumer { get; set; } = default!;

    public DeliveryPreferences DeliveryPreferences { get; set; } = default!;
    
    public DateTimeOffset OrderDate { get; set; }
    
    public List<OrderLineItem> OrderLineItems { get; set; } = default!;
}
