using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace practica.Models
{
    public class PractDbContext : DbContext
    {
        public PractDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Brigade> brigades { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Work> works { get; set; }

    }
}
