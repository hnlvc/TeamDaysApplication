namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class OrderLineItem
{
    public OrderLineArticle Article { get; set; } = default!;
    
    public int Quantity { get; set; }
    
    public List<string>? ScannableCodes { get; set; }
    
    public decimal ShopPrice { get; set; }
}