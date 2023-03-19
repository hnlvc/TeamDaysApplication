namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public record ConsumerAddress(
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