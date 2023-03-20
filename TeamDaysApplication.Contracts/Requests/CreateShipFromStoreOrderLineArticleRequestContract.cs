namespace TeamDaysApplication.Contracts.Requests;

/// <summary>
/// Response contract for a single order line article.
/// </summary>
public class CreateShipFromStoreOrderLineArticleRequestContract
{
    /// <summary>
    /// Optional location of an image of the article, should be accessible from public.  
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Article ID in the customer's shop system
    /// </summary>
    public string TenantArticleId { get; set; } = string.Empty;

    /// <summary>
    /// Title of the article.
    /// </summary>
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// Optional weight in grams of one single article.
    /// </summary>
    public decimal? Weight { get; set; }
}