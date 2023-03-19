namespace TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;

public record StrippedOrdersResponse(List<StrippedOrderItem> Orders, int Total);