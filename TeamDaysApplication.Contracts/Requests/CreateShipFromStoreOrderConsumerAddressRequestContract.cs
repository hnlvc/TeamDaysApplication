namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderConsumerAddressRequestContract(
    string? Email,
    string? Salutation,
    string? FirstName,
    string? LastName,
    string? CompanyName,
    string Street,
    string HouseNumber,
    string PostalCode,
    string City,
    string Country);