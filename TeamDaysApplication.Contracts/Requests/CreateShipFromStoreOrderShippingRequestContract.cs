namespace TeamDaysApplication.Contracts.Requests;

public record CreateShipFromStoreOrderShippingRequestContract(List<string> PrefferedCarriers, string ServiceLevel);