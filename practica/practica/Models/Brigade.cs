using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace practica.Models
{
    public class Brigade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ContactInformation { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}