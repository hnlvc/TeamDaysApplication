namespace TeamDaysApplication.Contracts.Requests;

public class CreateShipFromStoreOrderConsumerAddressRequestContract
{
    public string? Email { get; set; }
    
    public string? Salutation { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? CompanyName { get; set; }

    public string Street { get; set; } = default!;

    public string HouseNumber { get; set; } = default!;

    public string PostalCode { get; set; } = default!;

    public string City { get; set; } = default!;

    public string Country { get; set; } = default!;
}