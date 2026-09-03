using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Petshop.DAL
{
    public class PetshopDBcontext : DbContext
    {
        public PetshopDBcontext(DbContextOptions<PetshopDBcontext> options) : base(options)
        {
        }
        
    }
}
