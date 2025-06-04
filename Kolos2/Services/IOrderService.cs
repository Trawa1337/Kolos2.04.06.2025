using Kolos2.DTO_s;

namespace Kolos2.Services;

public interface IOrderService
{
    Task<OrderDto> GetOrders(int id);
}