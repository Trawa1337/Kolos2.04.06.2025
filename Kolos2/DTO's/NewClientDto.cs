namespace Kolos2.DTO_s;

public class NewClientDto
{
    public CustomerDto Customer { get; set; }
    public List<PurDto> Purchases { get; set; }
    
}

public class CustomerDto
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    
}

public class PurDto
{
    public int SeatNumber { get; set; }
    public string ConcertName { get; set; }
    public double Price { get; set; }
    
}