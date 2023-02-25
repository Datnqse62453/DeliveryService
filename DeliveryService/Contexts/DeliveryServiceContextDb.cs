using DeliveryService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Contexts
{
    public class DeliveryServiceContextDb : DbContext
    {
        public DeliveryServiceContextDb(DbContextOptions<DeliveryServiceContextDb> options) : base(options) 
        { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
