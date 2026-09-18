using WebApplication1.Petshop.DAL.Models;

namespace WebApplication1.Petshop.BLL.Interfaces
{
    public interface iuserservice

    {
        Task<User?> ValidateUserAsync(string email, string lozinka);
    }
}
