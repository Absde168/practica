using practica.Models;

namespace practica.Models
{

}
public class Member
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public int BrigadeId { get; set; }
    public Brigade Brigade { get; set; }
}
