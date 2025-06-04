using Kolos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomersController: ControllerBase
{
    private readonly IOrderService _orderService;

    public CustomersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("{id}/purchases")]
    public async Task<IActionResult> GetPurchase(int id)
    {
        var orders = await _orderService.GetOrders(id);
        if (orders == null)
        {
            return NotFound();
        }
            return Ok(orders);
    }
}