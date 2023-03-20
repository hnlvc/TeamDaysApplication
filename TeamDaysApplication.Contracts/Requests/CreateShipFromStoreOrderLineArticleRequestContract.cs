namespace TeamDaysApplication.Contracts.Requests;

/// <summary>
/// Response contract for a single order line article.
/// </summary>
public class CreateShipFromStoreOrderLineArticleRequestContract
{
    /// <summary>
    /// Article ID in the customer's shop system
    /// </summary>
    public string TenantArticleId { get; set; } = string.Empty;

    /// <summary>
    /// Title of the article.
    /// </summary>
    public string Title { get; set; } = string.Empty;
}