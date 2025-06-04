using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Data;

public class DatabaseContext:DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Ticket_Concert> Ticket_Concerts { get; set; }
    public DbSet<Purchased_Ticket> Purchased_Tickets { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected DatabaseContext()
    {
        
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
        {
            new Ticket() { TicketId = 1, SerialNumber = "qwerty", SeatNumber = 1 },
            new Ticket() { TicketId = 2, SerialNumber = "uiop", SeatNumber = 2 },
            new Ticket() { TicketId = 3, SerialNumber = "asdfg", SeatNumber = 3 },
        });
        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
        {
            new Concert()
                { ConcertId = 1, Name = "Zespol1", Date = DateTime.Parse("2025-06-18"), AvailableTickets = 6 },
            new Concert()
                { ConcertId = 2, Name = "Zespol2", Date = DateTime.Parse("2025-06-19"), AvailableTickets = 14 },
            new Concert()
                { ConcertId = 3, Name = "Zespol3", Date = DateTime.Parse("2025-06-17"), AvailableTickets = 20 },
        });
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "Kuba", LastName = "KubaN", PhoneNumber = "123456789" },
            new Customer() { CustomerId = 2, FirstName = "Pawel", LastName = "PawelN", PhoneNumber = "987654321" },
            new Customer() { CustomerId = 3, FirstName = "Janek", LastName = "JanekN", PhoneNumber = "135792468" },
        });
        modelBuilder.Entity<Ticket_Concert>().HasData(new List<Ticket_Concert>()
        {
            new Ticket_Concert() { TicketConcertId = 1, TicketId = 1, ConcertId = 1, Price = 10 },
            new Ticket_Concert() { TicketConcertId = 2, TicketId = 3, ConcertId = 2, Price = 43 },
            new Ticket_Concert() { TicketConcertId = 3, TicketId = 2, ConcertId = 3, Price = 35 }
        });
        modelBuilder.Entity<Purchased_Ticket>().HasData(new List<Purchased_Ticket>()
        {
            new Purchased_Ticket() { TicketConcertId = 1, CustomerId = 2, PurchaseDate = DateTime.Parse("2025-06-03") },
            new Purchased_Ticket() { TicketConcertId = 2, CustomerId = 1, PurchaseDate = DateTime.Parse("2025-06-04") }
        });
    }
    
}