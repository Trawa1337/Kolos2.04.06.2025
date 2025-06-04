using Kolos2.Data;
using Kolos2.DTO_s;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Services;

public class OrderService: IOrderService
{
    private readonly DatabaseContext _context;

    public OrderService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<OrderDto> GetOrders(int id)
    {
        var iduser =await _context.Customers.Where(c => c.CustomerId == id).Select(c => c.CustomerId).FirstOrDefaultAsync();
        if (iduser == null)
        {
            return null;
        }
        
            var order = await _context.Purchased_Tickets.Where(e=>e.Customer.CustomerId==id).Select(e => new OrderDto()
            {
                FirstName = e.Customer.FirstName,
                LastName = e.Customer.LastName,
                PhoneNumber = e.Customer.PhoneNumber,
                Purchases = new List<PurchaseDto>()

            }).FirstOrDefaultAsync();

            var purchase = await _context.Ticket_Concerts.Select(e => new PurchaseDto()
            {
                Date = e.Concert.Date,
                Price = e.Price,
                Ticket = new TicketDto()
                {
                    Serial = e.Ticket.SerialNumber,
                    SeatNumber = e.Ticket.SeatNumber,
                },
                Concert = new ConcertDto()
                {
                    Name = e.Concert.Name,
                    Date = e.Concert.Date,
                }
            }).FirstOrDefaultAsync();
            order.Purchases.Add(purchase);
            return order;
        



    }
}