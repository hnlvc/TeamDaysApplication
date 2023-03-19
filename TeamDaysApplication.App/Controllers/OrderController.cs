using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        var request = new GetOrderByOrderIdQuery();
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }
}