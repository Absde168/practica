namespace practica.Models
{

}
public class Work
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int BrigadeId { get; set; }
    public string Description { get; set; }
    public DateTime DateCompleted { get; set; }
    public decimal Cost { get; set; }
}

