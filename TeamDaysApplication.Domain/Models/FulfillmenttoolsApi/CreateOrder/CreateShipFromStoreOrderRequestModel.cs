namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public record CreateShipFromStoreOrderRequestModel(
    CreateOrderConsumerModel CreateOrderConsumerModel, 
    DateTimeOffset OrderDate, 
    string OrderStatus,
    string TenantOrderId,
    List<OrderLineItem> OrderLineItems,
    DeliveryPreferences DeliveryPreferences);