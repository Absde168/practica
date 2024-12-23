namespace practica.Models
{

}
public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactInformation { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Order> Orders { get; set; }
}
