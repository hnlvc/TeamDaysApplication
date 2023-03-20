namespace TeamDaysApplication.Contracts.Requests;

public class CreateShipFromStoreOrderConsumerAddressRequestContract
{
    /// <summary>
    /// Value for the coorect salutation
    /// </summary>
    public string Salutation { get; set; } = string.Empty;
    
    /// <summary>
    /// First name of our customer
    /// </summary>
    public string FirstName { get; set; } = string.Empty;
    
    /// <summary>
    /// Last name of our customer
    /// </summary>
    public string LastName { get; set; } = string.Empty;
    
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