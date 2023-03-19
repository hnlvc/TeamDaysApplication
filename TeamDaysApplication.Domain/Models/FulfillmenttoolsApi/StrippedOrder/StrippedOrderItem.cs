namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;

public record StrippedOrderItem(
    DateTimeOffset CreatedAt, 
    DateTimeOffset LastModifiedAt,
    int Version,
    string Id,
    DateTimeOffset OrderDate, 
    List<StrippedOrderLineItem> OrderLineItems, 
    string OrderStatus);