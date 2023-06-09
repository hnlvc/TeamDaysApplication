using MediatR;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;

namespace TeamDaysApplication.Core.Queries.Orders;

public record GetAllOrdersQuery() : IRequest<StrippedOrdersResponse?>;