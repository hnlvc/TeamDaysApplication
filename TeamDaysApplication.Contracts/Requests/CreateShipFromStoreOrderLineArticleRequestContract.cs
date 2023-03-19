namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderLineArticleRequestContract(
    string? ImageUrl, 
    string TenantArticleId, 
    string Title, 
    decimal? Weight);