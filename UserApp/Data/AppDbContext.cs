using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApp.Models;

namespace UserApp.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
