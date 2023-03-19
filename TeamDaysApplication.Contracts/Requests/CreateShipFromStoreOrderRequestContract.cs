namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderRequestContract(
    CreateShipFromStoreOrderConsumerRequestContract Consumer,
    DateTimeOffset OrderDate, 
    string OrderStatus,
    string TenantOrderId,
    List<CreateShipFromStoreOrderLineItemRequestContract> OrderLineItems,
    CreateShipFromStoreOrderDeliveryPreferencesRequestContract DeliveryPreferences);