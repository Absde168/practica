namespace practica.Models
{

}
public class Order
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalCost { get; set; }
    public ICollection<Work> Works { get; set; }
    public DateTime OrderDate { get; internal set; }
}