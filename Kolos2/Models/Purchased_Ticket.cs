using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Models;
[Table("Purchased_Ticket")]
[PrimaryKey(nameof(TicketConcertId),nameof(CustomerId))]
public class Purchased_Ticket
{
   [ForeignKey(nameof(Ticket_Concert))]
   public int TicketConcertId { get; set; }
   [ForeignKey(nameof(Customer))]
   public int CustomerId { get; set; }
   
   public DateTime PurchaseDate { get; set; }
   
   
   
   public Ticket_Concert Ticket_Concert { get; set; } 
   public Customer Customer { get; set; }
    
    
}