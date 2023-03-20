namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class Shipping
{
    public List<string> PreferredCarriers { get; set; } = default!;

    public string ServiceLevel { get; set; } = default!;
}