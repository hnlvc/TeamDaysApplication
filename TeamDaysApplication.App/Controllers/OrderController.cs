using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeamDaysApplication.Contracts.Requests;
using TeamDaysApplication.Core.Commands;
using TeamDaysApplication.Core.Queries.Orders;

namespace TeamDaysApplication.App.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("orders")]
    public async Task<ActionResult> GetOrdersAsync(CancellationToken cancellationToken)
    {
        var request = new GetAllOrdersQuery();
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    [Route("orders/shipFromStore")]
    public async Task<ActionResult> CreateShipFromStoreOrderAsync(
        [FromBody] CreateShipFromStoreOrderRequestContract request, CancellationToken cancellationToken)
    {
        var command = new CreateShipFromStoreOrderCommand(request);
        await _mediator.Send(command, cancellationToken);

        return Accepted();
    }
}