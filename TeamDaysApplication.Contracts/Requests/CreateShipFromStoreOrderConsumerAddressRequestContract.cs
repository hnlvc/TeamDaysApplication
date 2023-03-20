namespace TeamDaysApplication.Contracts.Requests;

public class CreateShipFromStoreOrderConsumerAddressRequestContract
{
    /// <summary>
    /// Optional value for customer's email address
    /// </summary>
    public string? Email { get; set; }
    
    /// <summary>
    /// Optional value for correct salutation.
    /// </summary>
    public string? Salutation { get; set; }
    
    /// <summary>
    /// Optional value for customer's first name.
    /// </summary>
    public string? FirstName { get; set; }
    
    /// <summary>
    /// Optional value for costumer's last name.
    /// </summary>
    public string? LastName { get; set; }
    
    /// <summary>
    /// Optional value for name of customer's company.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Street to shop to. 
    /// </summary>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// House number to ship to.
    /// </summary>
    public string HouseNumber { get; set; } = string.Empty;

    /// <summary>
    /// Postal Code to ship to.
    /// </summary>
    public string PostalCode { get; set; } = string.Empty;

    /// <summary>
    /// City where to ship to.
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// 2-digit country code.
    /// </summary>
    /// <example>"DE" for Germany</example>>
    public string Country { get; set; } = string.Empty;
}