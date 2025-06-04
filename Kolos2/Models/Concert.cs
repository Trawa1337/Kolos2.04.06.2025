using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos2.Models;
[Table("Concert")]
public class Concert
{
    [Key]
    public int ConcertId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int AvailableTickets { get; set; }

    public ICollection<Ticket_Concert> TicketConcerts { get; set; } = new HashSet<Ticket_Concert>();

}