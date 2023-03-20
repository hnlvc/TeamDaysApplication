namespace TeamDaysApplication.Contracts.Requests;

public class CreateShipFromStoreOrderDeliveryPreferencesRequestContract
{
    public CreateShipFromStoreOrderShippingRequestContract Shipping { get; set; } = default!;
}