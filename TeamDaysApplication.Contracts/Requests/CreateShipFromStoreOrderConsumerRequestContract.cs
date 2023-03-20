namespace TeamDaysApplication.Contracts.Requests;


public class CreateShipFromStoreOrderConsumerRequestContract
{
    /// <summary>
    /// List of addresses for the customer.
    /// </summary>
    public List<CreateShipFromStoreOrderConsumerAddressRequestContract> Addresses { get; set; } = default!;
    
    /// <summary>
    /// Optional email address of the customer. 
    /// </summary>
    public string? Email { get; set; }
}