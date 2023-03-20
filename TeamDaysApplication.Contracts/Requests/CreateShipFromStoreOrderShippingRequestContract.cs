namespace TeamDaysApplication.Contracts.Requests;

/// <summary>
/// Contract for the shipping preferences of a ship from store order.
/// </summary>
public class CreateShipFromStoreOrderShippingRequestContract
{
    /// <summary>
    /// List containing the customer's preferred delivery carriers.
    /// </summary>
    public List<string> PreferredCarriers { get; set; } = default!;

    /// <summary>
    /// Preferred service level for this ship from store order.
    /// </summary>
    public string ServiceLevel { get; set; } = "DELIVERY";
}