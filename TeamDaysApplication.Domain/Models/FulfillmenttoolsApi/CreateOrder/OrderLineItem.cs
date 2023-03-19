namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public record OrderLineItem(OrderLineArticle Article, int Quantity, List<string>? ScannableCodes, decimal ShopPrice);