using MediatR;
using TeamDaysApplication.Contracts.Requests;

namespace TeamDaysApplication.Core.Commands;

public record CreateShipFromStoreOrderCommand(CreateShipFromStoreOrderRequestContract Contract) : IRequest;