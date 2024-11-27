using Microsoft.AspNetCore.Identity;

namespace UserApp.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
