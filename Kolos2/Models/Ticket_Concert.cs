using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Models;
[Table("Ticket_Concert")]
public class Ticket_Concert
{
    [Key]
    public int TicketConcertId { get; set; }
    [ForeignKey(nameof(Concert))]
    public int ConcertId { get; set; }
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    
    [Precision(10,2)]
    public decimal Price { get; set; }
    
    
    
    
    public Concert Concert { get; set; }
    public Ticket Ticket { get; set; }
    
    public ICollection<Purchased_Ticket> Purchased_Tickets { get; set; } = new HashSet<Purchased_Ticket>();
    
}