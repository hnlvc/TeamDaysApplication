namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class OrderLineArticle
{
    public string? ImageUrl { get; set; }

    public string TenantArticleId { get; set; } = default!;

    public string Title { get; set; } = default!;
    
    public decimal? Weight { get; set; }
}