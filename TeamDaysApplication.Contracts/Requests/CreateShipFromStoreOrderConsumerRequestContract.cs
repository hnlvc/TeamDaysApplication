namespace TeamDaysApplication.Contracts.Requests;


public class CreateShipFromStoreOrderConsumerRequestContract
{
    /// <summary>
    /// List of addresses for the customer.
    /// </summary>
    public List<CreateShipFromStoreOrderConsumerAddressRequestContract> Addresses { get; set; } = default!;
}