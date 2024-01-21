using Microsoft.EntityFrameworkCore;
using VerstaApi.Data;
using VerstaApi.Models;

namespace VerstaApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }
        public async Task<Order?> GetOrderById(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Order?> CreateOrderFromDTO(CreateOrderDTO orderDto)
        {
            var order = new Order(orderDto);
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

    }
}
