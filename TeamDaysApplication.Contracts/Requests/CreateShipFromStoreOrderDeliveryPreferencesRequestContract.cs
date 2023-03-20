namespace TeamDaysApplication.Contracts.Requests;

public class CreateShipFromStoreOrderDeliveryPreferencesRequestContract
{
    public List<CreateShipFromStoreOrderShippingRequestContract> Shipping { get; set; } = default!;
}