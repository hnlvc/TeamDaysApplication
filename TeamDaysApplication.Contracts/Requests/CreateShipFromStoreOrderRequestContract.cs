namespace TeamDaysApplication.Contracts.Requests;

/// <summary>
/// Request contract for Creating a ship from store order.
/// </summary>
public class CreateShipFromStoreOrderRequestContract
{
    /// <summary>
    /// Consumer contract containing the customer's address and optional their email address.
    /// </summary>
    public CreateShipFromStoreOrderConsumerRequestContract Consumer { get; set; } = default!;
    
    /// <summary>
    /// Time when the order was placed.
    /// </summary>
    public DateTimeOffset OrderDate { get; set; }

    /// <summary>
    /// Current state of the order, is "OPEN" by default.
    /// </summary>
    public string OrderStatus { get; set; } = "OPEN";

    /// <summary>
    /// Order ID in the customer's shop system, optional. 
    /// </summary>
    public string? TenantOrderId { get; set; }

    /// <summary>
    /// List of the items the customer has ordered.
    /// </summary>
    public List<CreateShipFromStoreOrderLineItemRequestContract> OrderLineItems { get; set; } = default!;

    /// <summary>
    /// Delivery preferences of the customer.
    /// </summary>
    public CreateShipFromStoreOrderDeliveryPreferencesRequestContract DeliveryPreferences { get; set; } = default!;
}