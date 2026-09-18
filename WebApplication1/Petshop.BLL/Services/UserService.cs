using Microsoft.EntityFrameworkCore;
using WebApplication1.Petshop.BLL.Interfaces;
using WebApplication1.Petshop.DAL;
using WebApplication1.Petshop.DAL.Models;

namespace WebApplication1.Petshop.BLL.Services
{
    public class UserService : iuserservice
    {
        private protected PetshopDBcontext _context;
        public UserService(PetshopDBcontext context)
        {
            _context = context;
        }
        public async Task<User?> ValidateUserAsync(string email, string lozinka)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.email == email && x.lozinka.Equals(lozinka) );
            if (user == null)
            {
                return null;
            }
            return user;
        }
    }
}
