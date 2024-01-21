using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VerstaApi.Data;
using VerstaApi.Models;
using VerstaApi.Services;

namespace VerstaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderServie;
        public OrdersController(IOrderService orderService)
        {
            _orderServie = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var res =  await _orderServie.GetOrders();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var res = await _orderServie.GetOrderById(id);
            return Ok(res);
        }
        [HttpPut]
        public async Task<IActionResult> CreateOrder([FromForm] CreateOrderDTO dto)
        {
            var res = await _orderServie.CreateOrderFromDTO(dto);
            return Ok(res);
        }
    }
}
