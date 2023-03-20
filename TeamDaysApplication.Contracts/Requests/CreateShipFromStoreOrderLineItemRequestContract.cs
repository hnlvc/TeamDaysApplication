namespace TeamDaysApplication.Contracts.Requests;

/// <summary>
/// Request Contract for a single order line item. 
/// </summary>
public class CreateShipFromStoreOrderLineItemRequestContract
{
    /// <summary>
    /// Article for this Order line item.
    /// </summary>
    public CreateShipFromStoreOrderLineArticleRequestContract Article { get; set; } = default!;
    
    /// <summary>
    /// Quantity of this article
    /// </summary>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Optional list of scannable code, like the EAN/GTIN. 
    /// </summary>
    public List<string>? ScannableCodes { get; set; }
    
    /// <summary>
    /// Shop Price. 
    /// </summary>
    public decimal ShopPrice { get; set; }
}