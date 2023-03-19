namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderConsumerRequestContract(
    List<CreateShipFromStoreOrderConsumerAddressRequestContract> Addresses, 
    string? Email);