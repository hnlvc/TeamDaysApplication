namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;

public record StrippedOrderItem(
    string CreatedAt, 
    string LastModifiedAt,
    int Version,
    string Id,
    string OrderDate, 
    List<StrippedOrderLineItem> OrderLineItems, 
    string OrderStatus);