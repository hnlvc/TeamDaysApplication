namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class ConsumerAddress
{
    public string? Email { get; set; }
    
    public string? Salutation { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? CompanyName { get; set; }
#nullable disable
    public string Street { get; set; }

    public string HouseNumber { get; set; }
    
    public string PostalCode { get; set; }
    
    public string City { get; set; }
    
    public string Country { get; set; }
}