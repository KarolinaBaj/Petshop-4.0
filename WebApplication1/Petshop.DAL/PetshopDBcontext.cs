using Microsoft.EntityFrameworkCore;
using WebApplication1.Migrations;
using WebApplication1.Petshop.DAL.Models;

namespace WebApplication1.Petshop.DAL
{
    public class PetshopDBcontext : DbContext
    {
        public PetshopDBcontext(DbContextOptions<PetshopDBcontext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Orderitems> Orderitems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
