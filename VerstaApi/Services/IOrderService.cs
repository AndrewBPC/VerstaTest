using Microsoft.EntityFrameworkCore;
using VerstaApi.Models;

namespace VerstaApi.Services
{
    public interface IOrderService
    {
        public Task<List<Order>> GetOrders();
        public Task<Order?> GetOrderById(int id);
        public Task<Order?> CreateOrderFromDTO(CreateOrderDTO orderDto);
    }
}
