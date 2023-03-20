namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;

public class CreateOrderConsumerModel
{
    public List<ConsumerAddress> Addresses { get; set; } = default!;

    public string? Email { get; set; }
}