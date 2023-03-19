namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderLineItemRequestContract(
    CreateShipFromStoreOrderLineArticleRequestContract Article, 
    int Quantity, 
    List<string>? ScannableCodes, 
    decimal ShopPrice);